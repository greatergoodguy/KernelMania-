using UnityEngine;
using System.Collections;

public class GameFlow {
	
	public static IGameState gsInitializeApplication 	= new GSInitializeApplication();
	public static IGameState gsMenuStart 				= new GSMenuStart();
	public static IGameState gsMenuSelectMode 			= new GSMenuSelectMode();
	public static IGameState gsMode1 					= new GSMode1();
	public static IGameState gsMode2 					= new GSMode2();
	public static IGameState gsMode3 					= new GSMode3();
	public static IGameState gsEndGame 					= new GSEndGame();
	
}
