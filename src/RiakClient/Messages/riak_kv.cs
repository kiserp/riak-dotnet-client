// <copyright file="riak_kv.cs" company="Basho Technologies, Inc.">
// Copyright (c) 2011 - OJ Reeves & Jeremiah Peschka
// Copyright (c) 2014 - Basho Technologies, Inc.
//
// This file is provided to you under the Apache License,
// Version 2.0 (the "License"); you may not use this file
// except in compliance with the License.  You may obtain
// a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
// </copyright>

namespace RiakClient.Messages
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbGetClientIdResp")]
  public partial class RpbGetClientIdResp : global::ProtoBuf.IExtensible
  {
    public RpbGetClientIdResp() {}
    
    private byte[] _client_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"client_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] client_id
    {
      get { return _client_id; }
      set { _client_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbSetClientIdReq")]
  public partial class RpbSetClientIdReq : global::ProtoBuf.IExtensible
  {
    public RpbSetClientIdReq() {}
    
    private byte[] _client_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"client_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] client_id
    {
      get { return _client_id; }
      set { _client_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbGetReq")]
  public partial class RpbGetReq : global::ProtoBuf.IExtensible
  {
    public RpbGetReq() {}
    
    private byte[] _bucket;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"bucket", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] bucket
    {
      get { return _bucket; }
      set { _bucket = value; }
    }
    private byte[] _key;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] key
    {
      get { return _key; }
      set { _key = value; }
    }
    private uint _r = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"r", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint r
    {
      get { return _r; }
      set { _r = value; }
    }
    private uint _pr = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"pr", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint pr
    {
      get { return _pr; }
      set { _pr = value; }
    }
    private bool _basic_quorum = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"basic_quorum", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool basic_quorum
    {
      get { return _basic_quorum; }
      set { _basic_quorum = value; }
    }
    private bool _notfound_ok = default(bool);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"notfound_ok", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool notfound_ok
    {
      get { return _notfound_ok; }
      set { _notfound_ok = value; }
    }
    private byte[] _if_modified = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"if_modified", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] if_modified
    {
      get { return _if_modified; }
      set { _if_modified = value; }
    }
    private bool _head = default(bool);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"head", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool head
    {
      get { return _head; }
      set { _head = value; }
    }
    private bool _deletedvclock = default(bool);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"deletedvclock", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool deletedvclock
    {
      get { return _deletedvclock; }
      set { _deletedvclock = value; }
    }
    private uint _timeout = default(uint);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"timeout", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint timeout
    {
      get { return _timeout; }
      set { _timeout = value; }
    }
    private bool _sloppy_quorum = default(bool);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"sloppy_quorum", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool sloppy_quorum
    {
      get { return _sloppy_quorum; }
      set { _sloppy_quorum = value; }
    }
    private uint _n_val = default(uint);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"n_val", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint n_val
    {
      get { return _n_val; }
      set { _n_val = value; }
    }
    private byte[] _type = null;
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbGetResp")]
  public partial class RpbGetResp : global::ProtoBuf.IExtensible
  {
    public RpbGetResp() {}
    
    private readonly global::System.Collections.Generic.List<RpbContent> _content = new global::System.Collections.Generic.List<RpbContent>();
    [global::ProtoBuf.ProtoMember(1, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<RpbContent> content
    {
      get { return _content; }
    }
  
    private byte[] _vclock = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"vclock", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] vclock
    {
      get { return _vclock; }
      set { _vclock = value; }
    }
    private bool _unchanged = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"unchanged", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool unchanged
    {
      get { return _unchanged; }
      set { _unchanged = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbPutReq")]
  public partial class RpbPutReq : global::ProtoBuf.IExtensible
  {
    public RpbPutReq() {}
    
    private byte[] _bucket;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"bucket", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] bucket
    {
      get { return _bucket; }
      set { _bucket = value; }
    }
    private byte[] _key = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] key
    {
      get { return _key; }
      set { _key = value; }
    }
    private byte[] _vclock = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"vclock", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] vclock
    {
      get { return _vclock; }
      set { _vclock = value; }
    }
    private RpbContent _content;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public RpbContent content
    {
      get { return _content; }
      set { _content = value; }
    }
    private uint _w = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"w", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint w
    {
      get { return _w; }
      set { _w = value; }
    }
    private uint _dw = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"dw", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint dw
    {
      get { return _dw; }
      set { _dw = value; }
    }
    private bool _return_body = default(bool);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"return_body", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool return_body
    {
      get { return _return_body; }
      set { _return_body = value; }
    }
    private uint _pw = default(uint);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"pw", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint pw
    {
      get { return _pw; }
      set { _pw = value; }
    }
    private bool _if_not_modified = default(bool);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"if_not_modified", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool if_not_modified
    {
      get { return _if_not_modified; }
      set { _if_not_modified = value; }
    }
    private bool _if_none_match = default(bool);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"if_none_match", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool if_none_match
    {
      get { return _if_none_match; }
      set { _if_none_match = value; }
    }
    private bool _return_head = default(bool);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"return_head", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool return_head
    {
      get { return _return_head; }
      set { _return_head = value; }
    }
    private uint _timeout = default(uint);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"timeout", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint timeout
    {
      get { return _timeout; }
      set { _timeout = value; }
    }
    private bool _asis = default(bool);
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"asis", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool asis
    {
      get { return _asis; }
      set { _asis = value; }
    }
    private bool _sloppy_quorum = default(bool);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"sloppy_quorum", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool sloppy_quorum
    {
      get { return _sloppy_quorum; }
      set { _sloppy_quorum = value; }
    }
    private uint _n_val = default(uint);
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"n_val", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint n_val
    {
      get { return _n_val; }
      set { _n_val = value; }
    }
    private byte[] _type = null;
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbPutResp")]
  public partial class RpbPutResp : global::ProtoBuf.IExtensible
  {
    public RpbPutResp() {}
    
    private readonly global::System.Collections.Generic.List<RpbContent> _content = new global::System.Collections.Generic.List<RpbContent>();
    [global::ProtoBuf.ProtoMember(1, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<RpbContent> content
    {
      get { return _content; }
    }
  
    private byte[] _vclock = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"vclock", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] vclock
    {
      get { return _vclock; }
      set { _vclock = value; }
    }
    private byte[] _key = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] key
    {
      get { return _key; }
      set { _key = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbDelReq")]
  public partial class RpbDelReq : global::ProtoBuf.IExtensible
  {
    public RpbDelReq() {}
    
    private byte[] _bucket;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"bucket", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] bucket
    {
      get { return _bucket; }
      set { _bucket = value; }
    }
    private byte[] _key;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] key
    {
      get { return _key; }
      set { _key = value; }
    }
    private uint _rw = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"rw", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rw
    {
      get { return _rw; }
      set { _rw = value; }
    }
    private byte[] _vclock = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"vclock", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] vclock
    {
      get { return _vclock; }
      set { _vclock = value; }
    }
    private uint _r = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"r", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint r
    {
      get { return _r; }
      set { _r = value; }
    }
    private uint _w = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"w", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint w
    {
      get { return _w; }
      set { _w = value; }
    }
    private uint _pr = default(uint);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"pr", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint pr
    {
      get { return _pr; }
      set { _pr = value; }
    }
    private uint _pw = default(uint);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"pw", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint pw
    {
      get { return _pw; }
      set { _pw = value; }
    }
    private uint _dw = default(uint);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"dw", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint dw
    {
      get { return _dw; }
      set { _dw = value; }
    }
    private uint _timeout = default(uint);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"timeout", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint timeout
    {
      get { return _timeout; }
      set { _timeout = value; }
    }
    private bool _sloppy_quorum = default(bool);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"sloppy_quorum", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool sloppy_quorum
    {
      get { return _sloppy_quorum; }
      set { _sloppy_quorum = value; }
    }
    private uint _n_val = default(uint);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"n_val", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint n_val
    {
      get { return _n_val; }
      set { _n_val = value; }
    }
    private byte[] _type = null;
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbListBucketsReq")]
  public partial class RpbListBucketsReq : global::ProtoBuf.IExtensible
  {
    public RpbListBucketsReq() {}
    
    private uint _timeout = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"timeout", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint timeout
    {
      get { return _timeout; }
      set { _timeout = value; }
    }
    private bool _stream = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"stream", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool stream
    {
      get { return _stream; }
      set { _stream = value; }
    }
    private byte[] _type = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbListBucketsResp")]
  public partial class RpbListBucketsResp : global::ProtoBuf.IExtensible
  {
    public RpbListBucketsResp() {}
    
    private readonly global::System.Collections.Generic.List<byte[]> _buckets = new global::System.Collections.Generic.List<byte[]>();
    [global::ProtoBuf.ProtoMember(1, Name=@"buckets", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<byte[]> buckets
    {
      get { return _buckets; }
    }
  
    private bool _done = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"done", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool done
    {
      get { return _done; }
      set { _done = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbListKeysReq")]
  public partial class RpbListKeysReq : global::ProtoBuf.IExtensible
  {
    public RpbListKeysReq() {}
    
    private byte[] _bucket;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"bucket", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] bucket
    {
      get { return _bucket; }
      set { _bucket = value; }
    }
    private uint _timeout = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"timeout", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint timeout
    {
      get { return _timeout; }
      set { _timeout = value; }
    }
    private byte[] _type = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbListKeysResp")]
  public partial class RpbListKeysResp : global::ProtoBuf.IExtensible
  {
    public RpbListKeysResp() {}
    
    private readonly global::System.Collections.Generic.List<byte[]> _keys = new global::System.Collections.Generic.List<byte[]>();
    [global::ProtoBuf.ProtoMember(1, Name=@"keys", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<byte[]> keys
    {
      get { return _keys; }
    }
  
    private bool _done = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"done", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool done
    {
      get { return _done; }
      set { _done = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbMapRedReq")]
  public partial class RpbMapRedReq : global::ProtoBuf.IExtensible
  {
    public RpbMapRedReq() {}
    
    private byte[] _request;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"request", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] request
    {
      get { return _request; }
      set { _request = value; }
    }
    private byte[] _content_type;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"content_type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] content_type
    {
      get { return _content_type; }
      set { _content_type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbMapRedResp")]
  public partial class RpbMapRedResp : global::ProtoBuf.IExtensible
  {
    public RpbMapRedResp() {}
    
    private uint _phase = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"phase", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint phase
    {
      get { return _phase; }
      set { _phase = value; }
    }
    private byte[] _response = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"response", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] response
    {
      get { return _response; }
      set { _response = value; }
    }
    private bool _done = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"done", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool done
    {
      get { return _done; }
      set { _done = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbIndexReq")]
  public partial class RpbIndexReq : global::ProtoBuf.IExtensible
  {
    public RpbIndexReq() {}
    
    private byte[] _bucket;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"bucket", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] bucket
    {
      get { return _bucket; }
      set { _bucket = value; }
    }
    private byte[] _index;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] index
    {
      get { return _index; }
      set { _index = value; }
    }
    private RpbIndexReq.IndexQueryType _qtype;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"qtype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public RpbIndexReq.IndexQueryType qtype
    {
      get { return _qtype; }
      set { _qtype = value; }
    }
    private byte[] _key = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] key
    {
      get { return _key; }
      set { _key = value; }
    }
    private byte[] _range_min = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"range_min", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] range_min
    {
      get { return _range_min; }
      set { _range_min = value; }
    }
    private byte[] _range_max = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"range_max", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] range_max
    {
      get { return _range_max; }
      set { _range_max = value; }
    }
    private bool _return_terms = default(bool);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"return_terms", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool return_terms
    {
      get { return _return_terms; }
      set { _return_terms = value; }
    }
    private bool _stream = default(bool);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"stream", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool stream
    {
      get { return _stream; }
      set { _stream = value; }
    }
    private uint _max_results = default(uint);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"max_results", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint max_results
    {
      get { return _max_results; }
      set { _max_results = value; }
    }
    private byte[] _continuation = null;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"continuation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] continuation
    {
      get { return _continuation; }
      set { _continuation = value; }
    }
    private uint _timeout = default(uint);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"timeout", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint timeout
    {
      get { return _timeout; }
      set { _timeout = value; }
    }
    private byte[] _type = null;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] type
    {
      get { return _type; }
      set { _type = value; }
    }
    private byte[] _term_regex = null;
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"term_regex", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] term_regex
    {
      get { return _term_regex; }
      set { _term_regex = value; }
    }
    private bool _pagination_sort = default(bool);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"pagination_sort", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool pagination_sort
    {
      get { return _pagination_sort; }
      set { _pagination_sort = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"IndexQueryType")]
    public enum IndexQueryType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"eq", Value=0)]
      eq = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"range", Value=1)]
      range = 1
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbIndexResp")]
  public partial class RpbIndexResp : global::ProtoBuf.IExtensible
  {
    public RpbIndexResp() {}
    
    private readonly global::System.Collections.Generic.List<byte[]> _keys = new global::System.Collections.Generic.List<byte[]>();
    [global::ProtoBuf.ProtoMember(1, Name=@"keys", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<byte[]> keys
    {
      get { return _keys; }
    }
  
    private readonly global::System.Collections.Generic.List<RpbPair> _results = new global::System.Collections.Generic.List<RpbPair>();
    [global::ProtoBuf.ProtoMember(2, Name=@"results", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<RpbPair> results
    {
      get { return _results; }
    }
  
    private byte[] _continuation = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"continuation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] continuation
    {
      get { return _continuation; }
      set { _continuation = value; }
    }
    private bool _done = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"done", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool done
    {
      get { return _done; }
      set { _done = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbCSBucketReq")]
  public partial class RpbCSBucketReq : global::ProtoBuf.IExtensible
  {
    public RpbCSBucketReq() {}
    
    private byte[] _bucket;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"bucket", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] bucket
    {
      get { return _bucket; }
      set { _bucket = value; }
    }
    private byte[] _start_key;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"start_key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] start_key
    {
      get { return _start_key; }
      set { _start_key = value; }
    }
    private byte[] _end_key = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"end_key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] end_key
    {
      get { return _end_key; }
      set { _end_key = value; }
    }
    private bool _start_incl = (bool)true;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"start_incl", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)true)]
    public bool start_incl
    {
      get { return _start_incl; }
      set { _start_incl = value; }
    }
    private bool _end_incl = (bool)false;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"end_incl", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool end_incl
    {
      get { return _end_incl; }
      set { _end_incl = value; }
    }
    private byte[] _continuation = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"continuation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] continuation
    {
      get { return _continuation; }
      set { _continuation = value; }
    }
    private uint _max_results = default(uint);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"max_results", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint max_results
    {
      get { return _max_results; }
      set { _max_results = value; }
    }
    private uint _timeout = default(uint);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"timeout", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint timeout
    {
      get { return _timeout; }
      set { _timeout = value; }
    }
    private byte[] _type = null;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbCSBucketResp")]
  public partial class RpbCSBucketResp : global::ProtoBuf.IExtensible
  {
    public RpbCSBucketResp() {}
    
    private readonly global::System.Collections.Generic.List<RpbIndexObject> _objects = new global::System.Collections.Generic.List<RpbIndexObject>();
    [global::ProtoBuf.ProtoMember(1, Name=@"objects", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<RpbIndexObject> objects
    {
      get { return _objects; }
    }
  
    private byte[] _continuation = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"continuation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] continuation
    {
      get { return _continuation; }
      set { _continuation = value; }
    }
    private bool _done = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"done", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool done
    {
      get { return _done; }
      set { _done = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbIndexObject")]
  public partial class RpbIndexObject : global::ProtoBuf.IExtensible
  {
    public RpbIndexObject() {}
    
    private byte[] _key;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] key
    {
      get { return _key; }
      set { _key = value; }
    }
    private RpbGetResp _object;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"object", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public RpbGetResp @object
    {
      get { return _object; }
      set { _object = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbContent")]
  public partial class RpbContent : global::ProtoBuf.IExtensible
  {
    public RpbContent() {}
    
    private byte[] _value;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] value
    {
      get { return _value; }
      set { _value = value; }
    }
    private byte[] _content_type = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"content_type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] content_type
    {
      get { return _content_type; }
      set { _content_type = value; }
    }
    private byte[] _charset = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"charset", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] charset
    {
      get { return _charset; }
      set { _charset = value; }
    }
    private byte[] _content_encoding = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"content_encoding", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] content_encoding
    {
      get { return _content_encoding; }
      set { _content_encoding = value; }
    }
    private byte[] _vtag = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"vtag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] vtag
    {
      get { return _vtag; }
      set { _vtag = value; }
    }
    private readonly global::System.Collections.Generic.List<RpbLink> _links = new global::System.Collections.Generic.List<RpbLink>();
    [global::ProtoBuf.ProtoMember(6, Name=@"links", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<RpbLink> links
    {
      get { return _links; }
    }
  
    private uint _last_mod = default(uint);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"last_mod", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint last_mod
    {
      get { return _last_mod; }
      set { _last_mod = value; }
    }
    private uint _last_mod_usecs = default(uint);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"last_mod_usecs", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint last_mod_usecs
    {
      get { return _last_mod_usecs; }
      set { _last_mod_usecs = value; }
    }
    private readonly global::System.Collections.Generic.List<RpbPair> _usermeta = new global::System.Collections.Generic.List<RpbPair>();
    [global::ProtoBuf.ProtoMember(9, Name=@"usermeta", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<RpbPair> usermeta
    {
      get { return _usermeta; }
    }
  
    private readonly global::System.Collections.Generic.List<RpbPair> _indexes = new global::System.Collections.Generic.List<RpbPair>();
    [global::ProtoBuf.ProtoMember(10, Name=@"indexes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<RpbPair> indexes
    {
      get { return _indexes; }
    }
  
    private bool _deleted = default(bool);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"deleted", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool deleted
    {
      get { return _deleted; }
      set { _deleted = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbLink")]
  public partial class RpbLink : global::ProtoBuf.IExtensible
  {
    public RpbLink() {}
    
    private byte[] _bucket = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bucket", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] bucket
    {
      get { return _bucket; }
      set { _bucket = value; }
    }
    private byte[] _key = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] key
    {
      get { return _key; }
      set { _key = value; }
    }
    private byte[] _tag = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"tag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] tag
    {
      get { return _tag; }
      set { _tag = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbCounterUpdateReq")]
  public partial class RpbCounterUpdateReq : global::ProtoBuf.IExtensible
  {
    public RpbCounterUpdateReq() {}
    
    private byte[] _bucket;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"bucket", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] bucket
    {
      get { return _bucket; }
      set { _bucket = value; }
    }
    private byte[] _key;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] key
    {
      get { return _key; }
      set { _key = value; }
    }
    private long _amount;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"amount", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public long amount
    {
      get { return _amount; }
      set { _amount = value; }
    }
    private uint _w = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"w", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint w
    {
      get { return _w; }
      set { _w = value; }
    }
    private uint _dw = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"dw", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint dw
    {
      get { return _dw; }
      set { _dw = value; }
    }
    private uint _pw = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"pw", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint pw
    {
      get { return _pw; }
      set { _pw = value; }
    }
    private bool _returnvalue = default(bool);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"returnvalue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool returnvalue
    {
      get { return _returnvalue; }
      set { _returnvalue = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbCounterUpdateResp")]
  public partial class RpbCounterUpdateResp : global::ProtoBuf.IExtensible
  {
    public RpbCounterUpdateResp() {}
    
    private long _value = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long value
    {
      get { return _value; }
      set { _value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbCounterGetReq")]
  public partial class RpbCounterGetReq : global::ProtoBuf.IExtensible
  {
    public RpbCounterGetReq() {}
    
    private byte[] _bucket;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"bucket", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] bucket
    {
      get { return _bucket; }
      set { _bucket = value; }
    }
    private byte[] _key;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] key
    {
      get { return _key; }
      set { _key = value; }
    }
    private uint _r = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"r", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint r
    {
      get { return _r; }
      set { _r = value; }
    }
    private uint _pr = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"pr", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint pr
    {
      get { return _pr; }
      set { _pr = value; }
    }
    private bool _basic_quorum = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"basic_quorum", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool basic_quorum
    {
      get { return _basic_quorum; }
      set { _basic_quorum = value; }
    }
    private bool _notfound_ok = default(bool);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"notfound_ok", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool notfound_ok
    {
      get { return _notfound_ok; }
      set { _notfound_ok = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbCounterGetResp")]
  public partial class RpbCounterGetResp : global::ProtoBuf.IExtensible
  {
    public RpbCounterGetResp() {}
    
    private long _value = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long value
    {
      get { return _value; }
      set { _value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
