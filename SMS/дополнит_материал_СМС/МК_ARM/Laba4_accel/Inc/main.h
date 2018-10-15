/**
  ******************************************************************************
  * File Name          : main.h
  * Description        : This file contains the common defines of the application
  ******************************************************************************
  *
  * COPYRIGHT(c) 2017 STMicroelectronics
  *
  * Redistribution and use in source and binary forms, with or without modification,
  * are permitted provided that the following conditions are met:
  *   1. Redistributions of source code must retain the above copyright notice,
  *      this list of conditions and the following disclaimer.
  *   2. Redistributions in binary form must reproduce the above copyright notice,
  *      this list of conditions and the following disclaimer in the documentation
  *      and/or other materials provided with the distribution.
  *   3. Neither the name of STMicroelectronics nor the names of its contributors
  *      may be used to endorse or promote products derived from this software
  *      without specific prior written permission.
  *
  * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
  * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
  * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
  * DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
  * FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
  * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
  * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
  * CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
  * OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
  * OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
  *
  ******************************************************************************
  */
/* Define to prevent recursive inclusion -------------------------------------*/
#ifndef __MAIN_H
#define __MAIN_H
/* Includes ------------------------------------------------------------------*/

/* USER CODE BEGIN Includes */
#include "stdbool.h"
/* USER CODE END Includes */

/* Private define ------------------------------------------------------------*/

/* USER CODE BEGIN Private defines */
//------------------------------------------------
// Onboard LEDs:
#define LD_PORT GPIOD
#define LD3 GPIO_PIN_13 //ORANGE 	// UP				// NORTH
#define LD4 GPIO_PIN_12 //GREEN 	// LEFT			// WEST
#define LD5 GPIO_PIN_14 //RED			// RIGHT		// EAST
#define LD6 GPIO_PIN_15 //BLUE		// BOTTOM		// SOUTH
// LEDs control defines
#define LD3_ON 	HAL_GPIO_WritePin(LD_PORT, LD3, GPIO_PIN_SET) //ORANGE
#define LD4_ON 	HAL_GPIO_WritePin(LD_PORT, LD4, GPIO_PIN_SET) //GREEN
#define LD5_ON 	HAL_GPIO_WritePin(LD_PORT, LD5, GPIO_PIN_SET) //RED
#define LD6_ON 	HAL_GPIO_WritePin(LD_PORT, LD6, GPIO_PIN_SET) //BLUE
#define LD3_OFF HAL_GPIO_WritePin(LD_PORT, LD3, GPIO_PIN_RESET) //ORANGE
#define LD4_OFF HAL_GPIO_WritePin(LD_PORT, LD4, GPIO_PIN_RESET) //GREEN
#define LD5_OFF HAL_GPIO_WritePin(LD_PORT, LD5, GPIO_PIN_RESET) //RED
#define LD6_OFF HAL_GPIO_WritePin(LD_PORT, LD6, GPIO_PIN_RESET) //BLUE
//------------------------------------------------
/* USER CODE END Private defines */

/**
  * @}
  */ 

/**
  * @}
*/ 

#endif /* __MAIN_H */
/************************ (C) COPYRIGHT STMicroelectronics *****END OF FILE****/
