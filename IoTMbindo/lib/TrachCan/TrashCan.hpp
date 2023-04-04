#ifndef TRASHCAN_HPP
#define TRASHCAN_HPP

#include <Arduino.h>

#include <DetectorLevel.hpp>

class TrashCan
{
public:
    TrashCan( int echoPin = 7, int trigPin = 8);
    ~TrashCan(){delete detector;}
    void Begin();
    DetectorLevel getLevel(){return *TrashCan::detector;}
    bool getFullStepLevel(){return TrashCan::m_isFull;}

    void viewLevel();

private:
    bool m_isFull;
    DetectorLevel *detector;

};

#endif // TRASHCAN_HPP