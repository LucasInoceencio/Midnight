using System.Collections.Generic;

namespace Midnight
{
    public class Song
    {
        #region Description problem

        // Link: https://www.testdome.com/questions/c-sharp/song/48850?visibility=3&skillId=18

        // Level: Easy

        //A playlist is considered a repeating playlist if any of the songs contain a reference
        //to a previous song in the playlist. Otherwise, the playlist will end with the last song which points to null.

        //Implement a function IsRepeatingPlaylist that, efficiently with respect to time used,
        //returns true if a playlist is repeating or false if it is not.

        #endregion

        private string _name;
        public Song NextSong { get; set; }

        public Song(string name)
        {
            _name = name;
        }

        public bool IsRepeatingPlaylist()
        {
            var currentSong = this;
            HashSet<string> songs = new HashSet<string>();

            while (true)
            {
                if (currentSong.NextSong == null) return false;
                if (currentSong._name == currentSong.NextSong._name) return true;
                if (songs.Contains(currentSong._name)) return true;

                songs.Add(currentSong._name);
                currentSong = currentSong.NextSong;
            }
        }
    }
}
