using UnityEngine;
using System.Collections;


/*
 *	The name of this file starts with an underscore
 *	so that it pops to the beginning of the list.
 * 	This is purely a cosmetic purpose, so whether we call it 
 *  call it, _GameFlow, GameFlow or elephant, it won't 
 * 	affect how the application behaves.
 */

public class GameFlow {
	
	public static readonly IGameState gsInitializeApplication 	= new GSInitializeApplication();
	public static readonly IGameState gsMenuStart 		= new GSMenuStart();
	public static readonly IGameState gsMenuSelectMode 	= new GSMenuSelectMode();
	public static readonly IGameState gsMode1 			= new GSMode1();
	public static readonly IGameState gsMode2 			= new GSMode2();
	public static readonly IGameState gsMode3 			= new GSMode3();
	public static readonly IGameState gsEndGame 		= new GSEndGame();
	
	public static IGameState GetInitialGameState() {
		return gsInitializeApplication;
	}
	
}
