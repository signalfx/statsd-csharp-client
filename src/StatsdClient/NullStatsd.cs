using System;
using System.Collections.Generic;

namespace StatsdClient
{
    public class NullStatsd : IStatsd
    {
        public NullStatsd()
        {
            Commands = new List<string>();
        }

        public List<string> Commands { get; private set; }

        public void Send<TCommandType>(string name, int value, IDictionary<String, String> dimensions) where TCommandType : IAllowsInteger
        {
        }

        public void Add<TCommandType>(string name, int value, IDictionary<String, String> dimensions) where TCommandType : IAllowsInteger
        {
        }

        public void Send<TCommandType>(string name, double value, IDictionary<String, String> dimensions) where TCommandType : IAllowsDouble
        {
        }

        public void Add<TCommandType>(string name, double value, IDictionary<String, String> dimensionse) where TCommandType : IAllowsDouble
        {
        }

        public void Send<TCommandType>(string name, int value, double sampleRate, IDictionary<String, String> dimensions)
            where TCommandType : IAllowsInteger, IAllowsSampleRate
        {
        }

        public void Add<TCommandType>(string name, int value, double sampleRate, IDictionary<String, String> dimensions)
            where TCommandType : IAllowsInteger, IAllowsSampleRate
        {
        }

        public void Send<TCommandType>(string name, string value, IDictionary<String, String> dimensions) where TCommandType : IAllowsString
        {
        }

        public void Send()
        {
        }

        public void Add(Action actionToTime, string statName, double sampleRate = 1, IDictionary<String, String> dimensions = null)
        {
            actionToTime();
        }

        public void Send(Action actionToTime, string statName, double sampleRate = 1, IDictionary<String, String> dimensions = null)
        {
            actionToTime();
        }

        public void Send<TCommandType>(string name, double value, bool isDeltaValue, IDictionary<String, String> dimensions) where TCommandType : IAllowsDouble, IAllowsDelta
        {
        }
  }
}