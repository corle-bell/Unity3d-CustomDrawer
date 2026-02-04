//*************************************************
//----Author:       Cyy 
//
//----CreateDate:   2023-10-13 13:49:42
//
//----Desc:         Create By BM
//
//**************************************************
using UnityEngine;
using System;
using System.Reflection;

namespace Bm.Drawer
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ConstValueSelectAttribute : PropertyAttribute
    {
        public bool isAutoClose;
        public Type type;
        public Type FiledType;
        public bool isFindAllAssembly;
        public virtual void SetValue(string fieldName, object propertyRoot, string _text, int ArrayIndex)
        {
            
        }
    }
    
    [System.AttributeUsage(System.AttributeTargets.Class)]
    public class ConstValueContentAttribute : System.Attribute
    {
        
    }
    
    #region String
    [AttributeUsage(AttributeTargets.Field)]
    public class ConstStringSelectAttribute : ConstValueSelectAttribute
    {
        public ConstStringSelectAttribute(bool _isAutoClose=true) {
            this.isAutoClose = _isAutoClose;
            FiledType = typeof(string);
            isFindAllAssembly = false;
        }
        
        public ConstStringSelectAttribute(Type _type)
        {
            type = _type;
            this.isAutoClose = true;
            FiledType = typeof(string);
            isFindAllAssembly = false;
        }
        
        public ConstStringSelectAttribute(Type _type, bool _isAutoClose=true)
        {
            type = _type;
            this.isAutoClose = _isAutoClose;
            FiledType = typeof(string);
            isFindAllAssembly = false;
        }
        
        public ConstStringSelectAttribute(Type _type, bool _isAutoClose=true, bool _isFindAllAssembly=false)
        {
            type = _type;
            this.isAutoClose = _isAutoClose;
            isFindAllAssembly = _isFindAllAssembly;
            FiledType = typeof(string);
        }
        
        public override void SetValue(string fieldName, object propertyRoot, string _text, int ArrayIndex)
        {
            if (ArrayIndex>=0)
            {
                (propertyRoot as string[])[ArrayIndex] = _text;
            }
            else
            {
                var type = propertyRoot.GetType();
                var field = type.GetField(fieldName, BindingFlags.Public|BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.FlattenHierarchy);
                field.SetValue(propertyRoot, _text);
            }
        }
    }
    
    #endregion

    #region Int

    [AttributeUsage(AttributeTargets.Field)]
    public class ConstIntSelectAttribute : ConstValueSelectAttribute 
    {
        public ConstIntSelectAttribute(bool _isAutoClose=true) {
            this.isAutoClose = _isAutoClose;
            FiledType = typeof(int);
            isFindAllAssembly = false;
        }
        
        public ConstIntSelectAttribute(Type _type)
        {
            type = _type;
            this.isAutoClose = true;
            FiledType = typeof(int);
            isFindAllAssembly = false;
        }
        
        public ConstIntSelectAttribute(Type _type, bool _isAutoClose=true)
        {
            type = _type;
            this.isAutoClose = _isAutoClose;
            FiledType = typeof(int);
            isFindAllAssembly = false;
        }
        
        public ConstIntSelectAttribute(Type _type, bool _isAutoClose=true, bool _isFindAllAssembly=false)
        {
            type = _type;
            this.isAutoClose = _isAutoClose;
            FiledType = typeof(int);
            isFindAllAssembly = _isFindAllAssembly;
        }
        
        public override void SetValue(string fieldName, object propertyRoot, string _text, int ArrayIndex)
        {
            if (ArrayIndex>=0)
            {
                (propertyRoot as int[])[ArrayIndex] = int.Parse(_text);
            }
            else
            {
                var type = propertyRoot.GetType();
                var field = type.GetField(fieldName, BindingFlags.Public|BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.FlattenHierarchy);
                field.SetValue(propertyRoot, int.Parse(_text));
            }
        }
    }
    #endregion
    
}