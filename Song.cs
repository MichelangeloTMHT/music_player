using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace music_player
{
    public class Song
    {
        /// <summary>
        /// Приватный параметр Который на прямую менять нельзя  "Имя песни"
        /// </summary>
        private  string Name  { get; set; }
        
        /// <summary>
        /// Приватный параметр Который на прямую менять нельзя  "Имя Альбома"
        /// </summary>
        private  string Albom{ get; set; }
        
        
        /// <summary>
        /// Конструктор, который принимает в качестве параметров имя и альбом. 
        /// </summary>
        /// <param name="name">Имя песни</param>
        /// <param name="albom">Имя альбома</param>
        public Song(string name , string albom )
        {
            Name = name;
            Albom = albom;
          
        }
        
        /// <summary>
        /// Метод переходник который возвращает Имя песни (приватный параметр класса Song "Name"
        /// </summary>
        /// <returns>Вернет имя песни </returns>
        public  string GetName ()
        {
            return Name;
        }
        
        /// <summary>
        /// Метод вернет информацию в из какого альбома данная  песня
        /// </summary>
        /// <returns>Вернет имя песни и имя альбома из каторого эта песня</returns>
        public string GetInfo()
        {
            return $"Name: {Name} | Albom: {Albom}";
        }
        
    }
    
}