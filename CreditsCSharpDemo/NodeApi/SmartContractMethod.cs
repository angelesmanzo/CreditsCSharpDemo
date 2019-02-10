/**
 * Autogenerated by Thrift Compiler (0.12.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace NodeApi
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class SmartContractMethod : TBase
  {
    private string _returnType;
    private string _name;
    private List<SmartContractMethodArgument> _arguments;

    public string ReturnType
    {
      get
      {
        return _returnType;
      }
      set
      {
        __isset.returnType = true;
        this._returnType = value;
      }
    }

    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        __isset.name = true;
        this._name = value;
      }
    }

    public List<SmartContractMethodArgument> Arguments
    {
      get
      {
        return _arguments;
      }
      set
      {
        __isset.arguments = true;
        this._arguments = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool returnType;
      public bool name;
      public bool arguments;
    }

    public SmartContractMethod() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String) {
                ReturnType = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Name = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.List) {
                {
                  Arguments = new List<SmartContractMethodArgument>();
                  TList _list54 = iprot.ReadListBegin();
                  for( int _i55 = 0; _i55 < _list54.Count; ++_i55)
                  {
                    SmartContractMethodArgument _elem56;
                    _elem56 = new SmartContractMethodArgument();
                    _elem56.Read(iprot);
                    Arguments.Add(_elem56);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("SmartContractMethod");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (ReturnType != null && __isset.returnType) {
          field.Name = "returnType";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(ReturnType);
          oprot.WriteFieldEnd();
        }
        if (Name != null && __isset.name) {
          field.Name = "name";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Name);
          oprot.WriteFieldEnd();
        }
        if (Arguments != null && __isset.arguments) {
          field.Name = "arguments";
          field.Type = TType.List;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Arguments.Count));
            foreach (SmartContractMethodArgument _iter57 in Arguments)
            {
              _iter57.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("SmartContractMethod(");
      bool __first = true;
      if (ReturnType != null && __isset.returnType) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ReturnType: ");
        __sb.Append(ReturnType);
      }
      if (Name != null && __isset.name) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Name: ");
        __sb.Append(Name);
      }
      if (Arguments != null && __isset.arguments) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Arguments: ");
        __sb.Append(Arguments);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}