using System;
using System.Linq;
using System.Collections.Generic;
namespace RosterManagement
{
    public class CodeSchool
    {
        Dictionary<int, List<string>> _roster;
        public CodeSchool()
        {
          this._roster = new Dictionary<int, List<String>>();
        }
        public void Add(string cadet, int wave)
        {
             if (_roster.ContainsKey(wave))
                 _roster[wave].Add(cadet);
             else
                 _roster.Add(wave, new List<string> { cadet });
             _roster[wave].Sort();
        }
        public List<string> Grade(int wave)
        {
            var list = new List<string>();
           
            if (_roster.ContainsKey(wave))
            {
                return _roster[wave];
            }
            else
            {
                return list;
            }
        }
        public List<string> Roster()
        {
            var cadets = new List<string>();
              var sorted_index = _roster.Keys.ToList();
            sorted_index.Sort();
            foreach (int item in sorted_index)
            {
                cadets.AddRange(_roster[item]);
            }
            return cadets;
        }
    }
}