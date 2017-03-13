using Sanford.Multimedia.Midi;
using System;
using System.IO;

namespace Processor.FileUtils
{
    public class MidiFileOpener
    {        
        /*
         * Opens a midi file, given the path and track number.
         * Track number 0 doesn't hold any music, just tempo and beat
         * information.
         */
        public static Track OpenMidiFile(string aPath, int aTrackNumber = 1)
        {
            //blah blah blah test wether aPath is valid path

            using (var fileStream = new FileStream(aPath, FileMode.Open))
            {
                var sequence = new Sequence(fileStream);
                var tracks = sequence.GetEnumerator();
                
                if(aTrackNumber > sequence.Count)
                {
                    throw new Exception("Given track number is greater than max track number");
                }

                int currentIndex = 0;
                Track resultTrack = null;
                tracks.Reset();
                while (tracks.MoveNext())
                {
                    resultTrack = tracks.Current;
                    currentIndex++;

                    if(currentIndex == aTrackNumber)
                    {
                        break;
                    }
                }
                
                return resultTrack;                                  
            }
        }
    }
}
