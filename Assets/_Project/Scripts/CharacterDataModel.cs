using System.Collections.Generic;
using UnityEngine;

namespace _Project
{
    public class CharacterDataModel
    {
        public List<CharacterInfo> CharacterInfoList;

        public CharacterDataModel()
        {
            CharacterInfoList = new List<CharacterInfo>();
        }

        public void DebugLogInCharacterList()
        {
            foreach (var characterInfo in CharacterInfoList)
            {
                CharacterDataClassDebugLog(characterInfo);
            }
        }

        public static void CharacterDataClassDebugLog(CharacterInfo characterInfo)
        {
            Debug.Log("name : " + characterInfo.name + ", atk : " + characterInfo.atk + ", def : " + characterInfo.def + ", hp : " + characterInfo.hp + ", mp : " + characterInfo.mp);
        }
    }
}