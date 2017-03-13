using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Processor.Base
{
    public class Rest : IElement
    {
        public ERestValue RestValue { get; set; }
        public EDotType DotType { get; set; }

        public Rest(ERestValue aRestValue)
        {
            RestValue = aRestValue;         
        }

        public Rest(ERestValue aRestValue, EDotType aDotType) : this (aRestValue)
        {            
            DotType = aDotType;
        }
    }
}
