using System.Collections.Generic;

namespace _Project
{
    [System.Serializable]
    public class PlayerInfo
    {
        public float moveSpeed;
        public string color;
    }

    [System.Serializable]
    public class PlayerInfoList
    {
        public List<PlayerInfo> gameInfo;
    }
}