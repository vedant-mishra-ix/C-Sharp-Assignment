using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    interface WhatsApp
    {
       void Message();
    }
    interface FaceBook
    {
        void Message();
    }

    class Users:WhatsApp, FaceBook
    {
        public  void Message()
        {
            Console.WriteLine("I havn't time");
        }
    }
}


/*
In Git UI 

1.create new repo:
2. select ReadMe option:
3 select visiual studio option in .gitignore

In terminal
 
1. git init --- for create .git file
2. git remote add origin "Path repo"
3. git fetch: (what do you want to fetch from previous branch)
4. git checkout -b new branch name
5. git add .
6. git status
7. git commit -m "msg"
8. git push -u origin branch name
 */