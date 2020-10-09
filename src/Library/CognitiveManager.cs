using System;
using CognitiveCoreUCU;

namespace PII_Herencia
{
    public class CognitiveManager
    {
        private static Boolean FoundSmilingFace(CognitiveFace cog)
        {
            if (cog.FaceFound)
            {
                if (cog.SmileFound)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
        }

        public static Boolean FotoValida(string foto)
        {
            CognitiveFace cog = new CognitiveFace("620e818a46524ceb92628cde08068242", false);
            cog.Recognize(@foto);
            return FoundSmilingFace(cog);
        }
    }
}