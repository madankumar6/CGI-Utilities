using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Word_Extractor.Interfaces.Concrete
{
    public class WordExtractor : IWordExtractor
    {

        public void ReadFile(System.IO.Stream inputStream)
        {
            throw new NotImplementedException();
        }

        public string ExtractWordsFromFile(int startingPosition, int endingPosition)
        {
            throw new NotImplementedException();
        }

        public void WriteFile(OutputFileType outputFileType)
        {
            throw new NotImplementedException();
        }

        public void ProcessFile(System.IO.Stream inputStream, int startingPosition, int endingPosition, OutputFileType outputFileType)
        {
            throw new NotImplementedException();
        }

        public void ProcessFile(byte[] fileContent, int startingPosition, int endingPosition, OutputFileType outputFileType)
        {
            throw new NotImplementedException();
        }
    }
}
