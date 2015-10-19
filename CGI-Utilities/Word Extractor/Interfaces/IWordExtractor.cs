using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Word_Extractor.Interfaces
{
    interface IWordExtractor
    {
        void ReadFile(Stream inputStream);
        string ExtractWordsFromFile(int startingPosition, int endingPosition);
        void WriteFile(OutputFileType outputFileType);
        void ProcessFile(Stream inputStream, int startingPosition, int endingPosition, OutputFileType outputFileType);
        void ProcessFile(byte[] fileContent, int startingPosition, int endingPosition, OutputFileType outputFileType);
    }
}
