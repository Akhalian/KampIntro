using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDict<Id, Name>
    {
        Id[] id;
        Name[] name;
        public MyDict()
        {
            id = new Id[0];
            name = new Name[0];
        }

        Id[] tempid;
        Name[] tempname;

        public void Add(Id ids, Name names)
        {
            tempid = id;
            tempname = name;
            id = new Id[id.Length + 1];
            name = new Name[name.Length+1];
            
            for (int i = 0; i < tempid.Length; i++)
            {
                id[i] = tempid[i];
            }

            for (int i = 0; i < tempname.Length; i++)
            {
                name[i] = tempname[i];
            }

            id[id.Length - 1] = ids;
            name[name.Length - 1] = names;


        }

        public void GetAll()
        {
            for (int i = 0; i < id.Length; i++)
            {
                Console.WriteLine("Ad Soyad: " + id[i] + " " + name[i]);
            }
        }
    }
}
