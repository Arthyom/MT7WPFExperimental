#pragma once
ref class MT7Stroke
{
#ifndef __MT7STROKE_H__
#define __MT7STROKE_H__

#ifdef __cplusplus
	extern "C"
	{
#endif

		/******************************************************************************/
		/* I N C L U D E   F I L E S                                                  */

		/* Global Includes */

		/* Project Includes */
#include <MT7Trace.h>

		/* Local Includes */

		/******************************************************************************/
		/* C O N S T A N T S                                                          */

#ifndef MT7STROKE
#if defined (WIN32) || defined (UNDER_CE)
#define MT7STROKE __declspec (dllimport)
#else
#define MT7STROKE
#endif
#endif


		/******************************************************************************/
		/* G L O B A L   D A T A   T Y P E S                                          */

		typedef enum
		{
			MT7MatchReason_NoMatch = 0,
			MT7MatchReason_Match = 1,
		} MT7MatchReason;
		typedef struct tagMT7StrokeEngine * MT7StrokeEngine;
		typedef struct tagMT7StrokeMatch * MT7StrokeMatch;
		typedef void(*MT7StrokeCallback) (MT7MatchReason eReason,
			MT7StrokeMatch hMatch,
			void * pvUserCode);


		/******************************************************************************/
		/* P U B L I C   D A T A                                                      */


		/******************************************************************************/
		/* G L O B A L   D A T A                                                      */


		/******************************************************************************/
		/* G L O B A L   F U N C T I O N   P R O T O T Y P E S                        */


		/*
		** Engine API
		*/
		MT7STROKE MT7StrokeEngine MT7StrokeCreateEngine(const char * pszFile,
			MT7StrokeCallback fnCallback,
			void * pvUserCode);
		MT7STROKE MT7StrokeEngine MT7StrokeCloneEngine(MT7StrokeEngine hEngine,
			MT7StrokeCallback fnCallback,
			void * pvUserCode);
		MT7STROKE const char * MT7StrokeGetEngineName(MT7StrokeEngine hEngine);
		MT7STROKE const char * MT7StrokeGetEngineFile(MT7StrokeEngine hEngine);
		MT7STROKE unsigned int MT7StrokeGetEngineID(MT7StrokeEngine hEngine);
		MT7STROKE void MT7StrokeAddAllSensors(MT7StrokeEngine hEngine);
		MT7STROKE void MT7StrokeRemoveAllSensors(MT7StrokeEngine hEngine);
		MT7STROKE void MT7StrokeAddSensor(MT7StrokeEngine hEngine,
			MT7TraceSensor hSensor);
		MT7STROKE void MT7StrokeRemoveSensor(MT7StrokeEngine hEngine,
			MT7TraceSensor hSensor);
		MT7STROKE void MT7StrokeAddTrace(MT7StrokeEngine hEngine,
			MT7TraceTrace hTrace);
		MT7STROKE void MT7StrokeRemoveTrace(MT7StrokeEngine hEngine,
			MT7TraceTrace hTrace);
		MT7STROKE void MT7StrokeRemoveAllTraces(MT7StrokeEngine hEngine);
		MT7STROKE void MT7StrokeReleaseEngine(MT7StrokeEngine hEngine);

		/*
		** Match API
		*/
		MT7STROKE MT7StrokeMatch MT7StrokeCloneMatch(MT7StrokeMatch hMatch);
		MT7STROKE const char * MT7StrokeGetMatchName(MT7StrokeMatch hMatch);
		MT7STROKE unsigned int MT7StrokeGetMatchID(MT7StrokeMatch hMatch);
		MT7STROKE MT7StrokeEngine MT7StrokeGetMatchEngine(MT7StrokeMatch hMatch);
		MT7STROKE unsigned int MT7StrokeGetMatchTraceCount(MT7StrokeMatch hMatch);
		MT7STROKE MT7TraceTrace MT7StrokeGetMatchTrace(MT7StrokeMatch hMatch,
			unsigned int nIndex);
		MT7STROKE void MT7StrokeReleaseMatch(MT7StrokeMatch hMatch);

		/******************************************************************************/
		/* G L O B A L   M A C R O S                                                  */

#ifdef __cplusplus
	}
#endif

#endif /* ifndef __MT7STROKE_H__ */




};

