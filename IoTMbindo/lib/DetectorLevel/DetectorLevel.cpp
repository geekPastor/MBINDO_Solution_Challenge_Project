#include "DetectorLevel.hpp"

void DetectorLevel::detectLevel()
{
    long duration;
    // ============== SENDING THE FIRST IMPULSION ====================
  digitalWrite(DetectorLevel::trigPin, LOW); delayMicroseconds(5);
  digitalWrite(DetectorLevel::trigPin, HIGH); delayMicroseconds(10);
  digitalWrite(DetectorLevel::trigPin, LOW);
  // ============= END OF THE FIRST PULSATION ========================
  // =================== CALCULATE THE DURATION & DISTANCE ======================

  duration = pulseIn(DetectorLevel::echoPin, HIGH); DetectorLevel::distance = duration*0.034/2;
}
double DetectorLevel::getLevel()
{
    return (((DetectorLevel::maxLength - DetectorLevel::distance)/DetectorLevel::maxLength) * 100.0);
}

void DetectorLevel::Begin()
{
    pinMode(trigPin, OUTPUT); pinMode(echoPin, INPUT);
}