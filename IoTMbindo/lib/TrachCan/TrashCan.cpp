#include "TrashCan.hpp"

TrashCan::TrashCan( int echo, int trig)
{
    detector = new DetectorLevel(echo, trig);
    m_isFull = false;
}

void TrashCan::Begin()
{
    detector->Begin();
}

void TrashCan::viewLevel()
{
    detector->detectLevel();
    if(detector->getDistance() <= 1){m_isFull = true;}
    else {m_isFull = false;}
}
