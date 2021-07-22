using Midnight;
using System;
using System.Collections.Generic;
using System.Text;

namespace MidnightTest
{
    public class SongFixture : IDisposable
    {
        public Song firstUnique;
        public Song secondUnique;
        public Song thirdUnique;

        public Song firstRepeated;
        public Song secondRepeated;
        public Song thirdRepeated;

        public SongFixture()
        {
            firstUnique = new Song("Hello");
            secondUnique = new Song("Not afraid");
            thirdUnique = new Song("Eye of the tiger");

            firstRepeated = new Song("Hello");
            secondRepeated = new Song("Not afraid");
            thirdRepeated = new Song("Eye of the tiger");

            firstUnique.NextSong = secondUnique;
            secondUnique.NextSong = thirdUnique;

            firstRepeated.NextSong = secondRepeated;
            secondRepeated.NextSong = thirdRepeated;
            thirdRepeated.NextSong = firstRepeated;
        }

        public void Dispose() {}
    }
}
