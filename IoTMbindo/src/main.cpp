#include <Arduino.h>
#include <DetectorLevel.hpp>

#include <TrashCan.hpp>

#if defined(ESP32)
  #include <WiFi.h>
#elif defined(ESP8266)
  #include <ESP8266WiFi.h>
#endif

#include <Firebase_ESP_Client.h>

// Provide the token generation process info
#include "addons/TokenHelper.h"

// Provide the RTDB payload printing info and other helper functions
#include "addons/RTDBHelper.h"

#define WIFI_SSID "Verizon XT1650 9729"
#define WIFI_PASSWORD "KyuAndi2"

// Insert Firebas project API Key
#define API_KEY "AIzaSyDSopewLv8tGKeyjAwKchd_lrCka4aTL5E"

// Insert REALTIME DB URL 
#define DATABASE_URL "https://iotbopeto-default-rtdb.europe-west1.firebasedatabase.app/"

// FireBase data Object
FirebaseData fbdo; FirebaseAuth auth; FirebaseConfig config;


#define baudrate 9600

unsigned long previousMillis = 0;     // will store last time LED was updated
const long interval = 500;           // interval at which to blink (milliseconds)
bool signUpOk = false;

TrashCan *theBin = new TrashCan(4, 2);

void setup()
{
  Serial.begin(baudrate); theBin->getLevel().setMaxLength(65);
  
  theBin->Begin();
  Serial.begin(115200);
  WiFi.begin(WIFI_SSID, WIFI_PASSWORD);

  Serial.print("Connecting to WiFi");
  while(WiFi.status() != WL_CONNECTED)
  {
    Serial.print(".");
    delay(300);
  }

  Serial.println("Connected with IP : ");
  Serial.print(WiFi.localIP());
  Serial.println();

  // Assign the API Key (Required) !
  config.api_key = API_KEY;

  // Assign the realDataBase url (Required) !
  config.database_url = DATABASE_URL;
// Sign UP
  if(Firebase.signUp(&config, &auth, "", ""))
  {
    Serial.println("OK");
    signUpOk = true;
  }

  else
  {
    Serial.printf("%s", config.signer.signupError.message.c_str());
  }

  // Assign the callback function for the long running token generation task 
  config.token_status_callback = tokenStatusCallback; //see addons/TokenHelper.h

  Firebase.begin(&config, &auth);
  Firebase.reconnectWiFi(true);
}

void loop()
{

  unsigned long currentMillis = millis();

  if (Firebase.ready() && signUpOk && (currentMillis - previousMillis >= interval))
  {
    // save the last time we trash was see level
    previousMillis = currentMillis;
    theBin->viewLevel(); theBin->getLevel().ShowCentimeter();
    if(theBin->getFullStepLevel())
    {
      // We send a JSON file or execute a link to send to firebase
      // Or we execute a AT-COMMAND
      Serial.println("Trash is full");
    }
    if (Firebase.RTDB.setInt(&fbdo, "TrahCan/level", theBin->getLevel().getLevel())){
      Serial.println("PASSED");
      Serial.println("PATH: " + fbdo.dataPath());
      Serial.println("TYPE: " + fbdo.dataType());
    }
    else {
      Serial.println("FAILED");
      Serial.println("REASON: " + fbdo.errorReason());
    }
  }
}