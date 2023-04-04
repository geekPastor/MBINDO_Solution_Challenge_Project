#ifndef DETECTORLEVEL_HPP
#define DETECTORLEVEL_HPP

#include <Arduino.h>

class DetectorLevel
{
public:
    DetectorLevel(int echo, int trigger, double maximumLength = 50.0) : trigPin(trigger), echoPin(echo), maxLength(maximumLength){}
    ~DetectorLevel(){}

    void detectLevel(); double getLevel();
    void setMaxLength(double maxL){ DetectorLevel::maxLength = maxL;}
    void Begin();

    double getDistance(){return DetectorLevel::distance;}
    void ShowCentimeter(){Serial.print("Distance : "); Serial.print(DetectorLevel::distance); Serial.println(" cm");}
private:
    /* data */
    int trigPin;
    int echoPin;

    double distance;
    double maxLength;
    //long duration;
};




#endif // DETECTORLEVEL_HPP
