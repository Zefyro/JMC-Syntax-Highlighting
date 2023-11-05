﻿namespace JMC.Shared.Datas.Minecraft.Blocks
{
    internal class BlockDataContainer(IEnumerable<BlockData> datas) : List<BlockData>(datas)
    {
        //TODO support differnt namespace
        public bool IsExist(string data)
        {
            if (data.StartsWith('#'))
            {
                data = data[1..];
                if (!data.StartsWith("minecraft:") && data.Split(':').Length > 1)
                    return false;
                if (!data.StartsWith("minecraft:"))
                    data += "minecraft:";
                return ExtensionData.BlockTags.Any(v => v == data);
            }
            else
            {
                if (!data.StartsWith("minecraft:") && data.Split(':').Length > 1)
                    return false;
                if (!data.StartsWith("minecraft:"))
                    data += "minecraft:";
                return this.Any(v => v.Name == data);
            }
        }
    }
}
