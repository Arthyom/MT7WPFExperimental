#include "stdafx.h"
#include "MT7Trace.h"


/*
** Enumeration API
*/

MT7TraceEnum wMT7TraceCreateEnum(void)
{
	return MT7TraceCreateEnum();
}

unsigned int wMT7TraceGetEnumID(MT7TraceEnum hEnumerator)
{
	return MT7TraceGetEnumID(hEnumerator);
}

MT7TraceEnum wMT7TraceCloneEnum(MT7TraceEnum hEnumerator)
{
	return MT7TraceCloneEnum(hEnumerator);
}

MT7TraceSensor wMT7TraceGetNextSensor(MT7TraceEnum hEnumerator)
{
	return MT7TraceGetNextSensor(hEnumerator);
}

void wMT7TraceReleaseEnum(MT7TraceEnum hEnumerator)
{
	return MT7TraceReleaseEnum(hEnumerator);
}


/*
** Sensor API
*/
unsigned int wMT7TraceGetSensorID(MT7TraceSensor hSensor)
{
	return MT7TraceGetSensorID(hSensor);
}
const char * wMT7TraceGetSensorName(MT7TraceSensor hSensor)
{
	return MT7TraceGetSensorName(hSensor);
}
MT7TraceSensor wMT7TraceCloneSensor(MT7TraceSensor hSensor)
{
	return MT7TraceCloneSensor(hSensor);
}
MT7TraceTrace wMT7TraceGetNextTrace(MT7TraceSensor hSensor)
{
	return MT7TraceGetNextTrace(hSensor);
}
void wMT7TraceSetSensorCallback(MT7TraceSensor hSensor, MT7TraceCallback fnCallback, void * pvUserCode)
{
	return MT7TraceSetSensorCallback(hSensor, fnCallback, pvUserCode);
}
void wMT7TraceReleaseSensor(MT7TraceSensor hSensor)
{
	return MT7TraceReleaseSensor(hSensor);
}



/*
** Trace API
*/
unsigned int wMT7TraceGetTraceID(MT7TraceTrace hTrace)
{
	return MT7TraceGetTraceID(hTrace);

}
MT7TraceTrace wMT7TraceCloneTrace(MT7TraceTrace hTrace)
{
	return MT7TraceCloneTrace(hTrace);
}

MT7TraceEvent wMT7TraceGetNextEvent(MT7TraceTrace hTrace)
{
	return MT7TraceGetNextEvent(hTrace);
}

MT7TraceEvent wMT7TraceGetPriorEvent(MT7TraceTrace hTrace, unsigned int nOffset)
{
	return MT7TraceGetPriorEvent(hTrace, nOffset);
}

void wMT7TraceSetNextEvent(MT7TraceTrace hTrace, unsigned int nIndex)
{
	return MT7TraceSetNextEvent(hTrace, nIndex);
}
unsigned int wMT7TraceGetEventCount(MT7TraceTrace hTrace)
{
	return MT7TraceGetEventCount(hTrace);
}
MT7TraceEvent wMT7TraceGetEvent(MT7TraceTrace hTrace, unsigned int nIndex)
{
	return MT7TraceGetEvent(hTrace, nIndex);
}
MT7TraceSensor wMT7TraceGetTraceSensor(MT7TraceTrace hTrace)
{
	return MT7TraceGetTraceSensor(hTrace);
}
void wMT7TraceSetTraceCallback(MT7TraceTrace hTrace, MT7TraceCallback fnCallback, void * pvUserCode)
{
	return MT7TraceSetTraceCallback(hTrace, fnCallback, pvUserCode);
}
void wMT7TraceReleaseTrace(MT7TraceTrace hTrace)
{
	return MT7TraceReleaseTrace(hTrace);
}

/*
** Event API
*/
unsigned int wMT7TraceGetEventID(MT7TraceEvent hEvent)
{
	return MT7TraceGetEventID(hEvent);
}
MT7TraceEvent wMT7TraceCloneEvent(MT7TraceEvent hEvent)
{
	return MT7TraceCloneEvent(hEvent);
}
MT7TraceEventType wMT7TraceGetEventType(MT7TraceEvent hEvent)
{
	return MT7TraceGetEventType(hEvent);
}
float wMT7TraceGetEventX(MT7TraceEvent hEvent)
{
	return MT7TraceGetEventX(hEvent);
}
float wMT7TraceGetEventY(MT7TraceEvent hEvent)
{
	return MT7TraceGetEventY(hEvent);
}
unsigned int wMT7TraceGetEventTime(MT7TraceEvent hEvent)
{
	return MT7TraceGetEventTime(hEvent);
}
MT7TraceTrace wMT7TraceGetEventTrace(MT7TraceEvent hEvent)
{
	return MT7TraceGetEventTrace(hEvent);
}
void wMT7TraceReleaseEvent(MT7TraceEvent hEvent)
{
	return MT7TraceReleaseEvent(hEvent);
}

/*	
** Monitor/Poll API
*/
int wMT7TracePoll(void)
{
	return MT7TracePoll();
}
int wMT7TraceStartMonitor(void)
{
	return MT7TraceStartMonitor();
}
void wMT7TraceStopMonitor(void)
{
	return MT7TraceStopMonitor();
}
void wMT7TraceSetArrivalCallback(MT7TraceCallback fnCallback, void * pvUserCode)
{
	return MT7TraceSetArrivalCallback(fnCallback, pvUserCode);
}
void wMT7TraceSetUniversalCallback(MT7TraceCallback fnCallback, void * pvUserCode)
{
	return MT7TraceSetUniversalCallback(fnCallback, pvUserCode);
}
