//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Control
{
    [Serializable]
    public class InterfaceValueMsg : Message
    {
        public const string k_RosMessageName = "control_msgs/InterfaceValue";
        public override string RosMessageName => k_RosMessageName;

        //  List of resource interface names
        public string[] interface_names;
        //  Values corresponding to the list of interfaces in `interface_names`, [1.0, 0.0] for example
        public double[] values;

        public InterfaceValueMsg()
        {
            this.interface_names = new string[0];
            this.values = new double[0];
        }

        public InterfaceValueMsg(string[] interface_names, double[] values)
        {
            this.interface_names = interface_names;
            this.values = values;
        }

        public static InterfaceValueMsg Deserialize(MessageDeserializer deserializer) => new InterfaceValueMsg(deserializer);

        private InterfaceValueMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.interface_names, deserializer.ReadLength());
            deserializer.Read(out this.values, sizeof(double), deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.WriteLength(this.interface_names);
            serializer.Write(this.interface_names);
            serializer.WriteLength(this.values);
            serializer.Write(this.values);
        }

        public override string ToString()
        {
            return "InterfaceValueMsg: " +
            "\ninterface_names: " + System.String.Join(", ", interface_names.ToList()) +
            "\nvalues: " + System.String.Join(", ", values.ToList());
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
