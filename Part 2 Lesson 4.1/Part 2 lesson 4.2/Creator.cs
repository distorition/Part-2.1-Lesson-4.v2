using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_lesson_4._2
{
   public   class Creator
    {
        private Dictionary<int, HashSet<Houses>> table;

        public  Creator()
        {
            table = new Dictionary<int, HashSet<Houses>>();
        }

        public IReadOnlyCollection<KeyValuePair<int, HashSet<Houses>>> Items => table?.ToList()?.AsReadOnly();

        public  void CreatBulild(int height,int floor,int dors, int entance)
        {

            var house = new Houses( height,  floor,  dors,  entance);
            var hash = GetHash(house.NumHouse);
            HashSet<Houses> houses = null;
            if(table.ContainsKey(hash))
            {
                houses = table[hash];
                table[hash].Add(house);
            }
            else
            {
                houses = new HashSet<Houses> { house };
                table.Add(hash, houses);
            }
        }
        public  void REmove(int index)
        {
            var hash = GetHash(index);
            if (!table.ContainsKey(hash))
            {
                return;
            }
            var hashTable = table[hash];
            var item = hashTable.SingleOrDefault(g => g.NumHouse == index);
            if(item!=null)
            {
                hashTable.Remove(item);
            }
        }

       
      public static int GetHash(int value)
        {
            var hash = value;
            return hash;
        }
    }
}
