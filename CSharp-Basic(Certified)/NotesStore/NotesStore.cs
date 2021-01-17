using System;
using System.Collections.Generic;

namespace NotesStore
{
    public class NotesStore
    {
        private Dictionary<string, List<string>> notes;

        public NotesStore()
        {
            notes = new Dictionary<string, List<string>> 
            {
                { "completed", new List<string>() }, 
                { "active", new List<string>() }, 
                { "others", new List<string>() } 
            };
        }

        public void AddNote(String state, String name)
        {

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Name cannot be empty");
            }

            if (state == "completed")
            {
                notes[state].Add(name);
            }
            else if (state == "active")
            {
                notes[state].Add(name);
            }
            else if (state == "others")
            {
                notes[state].Add(name);
            }
            else
            {
                throw new Exception($"Invalid state {state}");
            }
        }

        public List<String> GetNotes(String state)
        {
            if (state == "completed" || state == "active" || state == "others")
            {
                List<string> result = notes[state].GetRange(0, notes[state].Count);
                
                return result;
            }

            throw new Exception($"Invalid state {state}");
        }
    }
}
