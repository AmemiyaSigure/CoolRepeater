﻿using Native.Sdk.Cqp;
using Native.Sdk.Cqp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cx.rain.cq.coolrepeater.Code
{
    public class CoolRepeater
    {
        public static CQApi Api = null;

        public static readonly Dictionary<string, Tuple<long, QQMessage>> GroupLastMessages = new Dictionary<string, Tuple<long, QQMessage>>();
        public static readonly Dictionary<string, HashSet<long>> GropuMessageSenders = new Dictionary<string, HashSet<long>>();
        public static readonly Dictionary<string, QQMessage> GroupRepeatedMessages = new Dictionary<string, QQMessage>();

        public static int RepeatThreshold = 3;
        public static bool IgnoreAnonymous = true;
        public static bool IgnorePicture = false;
        public static bool GreaterChancesMoreRepeat = false;
        public static decimal RepeatProbability = 0.6M;
        public static List<string> BlockWords = new List<string>();
        public static List<long> EnabledGroups = new List<long>();
        public static List<long> DisabledGroups = new List<long>();
    }
}
