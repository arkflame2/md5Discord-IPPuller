﻿namespace PixelPlanetUtils.NetworkInteraction.Websocket
{
    public class PixelReturnData
    {
        public ReturnCode ReturnCode { get; set; }

        public uint Wait { get; set; }

        public short CoolDownSeconds { get; set; }
    }
}
