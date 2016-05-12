using System;
using System.Collections.Generic;

namespace StatsdClient
{
    public interface IStatsd
    {
        List<string> Commands { get; }
        
        void Send<TCommandType>(string name, int value, IDictionary<String, String> dimensions) where TCommandType : IAllowsInteger;
        void Add<TCommandType>(string name, int value, IDictionary<String, String> dimensions) where TCommandType : IAllowsInteger;

        void Send<TCommandType>(string name, double value, IDictionary<String, String> dimensions) where TCommandType : IAllowsDouble;
        void Add<TCommandType>(string name, double value, IDictionary<String, String> dimensions) where TCommandType : IAllowsDouble;
        void Send<TCommandType>(string name, double value, bool isDeltaValue, IDictionary<String, String> dimensions) where TCommandType : IAllowsDouble, IAllowsDelta;

        void Send<TCommandType>(string name, int value, double sampleRate, IDictionary<String, String> dimensions) where TCommandType : IAllowsInteger, IAllowsSampleRate;
        void Add<TCommandType>(string name, int value, double sampleRate, IDictionary<String, String> dimensions) where TCommandType : IAllowsInteger, IAllowsSampleRate;

        void Send<TCommandType>(string name, string value, IDictionary<String, String> dimensions) where TCommandType : IAllowsString;

        void Send();

        void Add(Action actionToTime, string statName, double sampleRate = 1, IDictionary<String, String> dimensions = null);
        void Send(Action actionToTime, string statName, double sampleRate = 1, IDictionary<String, String> dimensions = null);
    }
}