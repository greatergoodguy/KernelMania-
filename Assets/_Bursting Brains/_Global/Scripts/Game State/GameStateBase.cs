using UnityEngine;
using System.Collections;

public abstract class GameStateBase : IGameState {
        
        public GameStateBase() {}
        
        public virtual void StartState () {}
        public virtual void Update () {}
        public virtual void ExitState () {}
        
        public abstract bool IsFinished();
        public abstract IGameState GetNextGameState() ;
}