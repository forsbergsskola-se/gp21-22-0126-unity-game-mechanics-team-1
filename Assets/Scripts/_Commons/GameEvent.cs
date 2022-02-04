using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Values/GameEvent", fileName = "NewEvent")]
public class GameEvent : ScriptableObject
{ 
    private readonly List<GameEventListener> _listeners = new List<GameEventListener>();

    public void Raise()
    { 
        foreach (var gameEventListener in _listeners)
        {
            gameEventListener.OnEventRaised();
        }
    }

    public void Register(GameEventListener listener) => _listeners.Add(listener);
        
    public void Unregister(GameEventListener listener) => _listeners.Remove(listener);
}  
    
   
