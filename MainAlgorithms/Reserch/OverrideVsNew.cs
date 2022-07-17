using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.Reserch
{   
    public class Base
    {
        private string _className;
        public virtual string GetClassName() => _className;
        public Base()
        {
            _className = nameof(Base);
            _property = _className;
            _virtualProperty = _className;
        }
        public string GetString()
        {
            return _className;
        }
        public virtual string GetVirtualString()
        {
            return _className;
        }

        private string _property;
        public string Property
        {
            get => _property;
            set => _property = value;
        }

        private string _virtualProperty;
        public virtual string VirtualProperty
        {
            get => _virtualProperty;
            set => _virtualProperty = value;
        }
    }
    public class Child : Base
    {
        private string _className;
        public override string GetClassName() => _className;
        public Child()
        {
            _className = nameof(Child);
            _property = _className;
            _virtualProperty = _className;
        }
        public new string GetString()
        {
            return _className;
        }
        public override string GetVirtualString()
        {
            return _className;
        }

        private string _property;
        public new string Property
        {
            get => _property;
            set => _property = value;
        }

        private string _virtualProperty;
        public override string VirtualProperty 
        { 
            get => _virtualProperty; 
            set => _virtualProperty = value; 
        }
    }
    public class BaseTest
    {
        public bool Test()
        {
            Base objectBase = Init();
            bool result = objectBase.GetClassName().Equals(objectBase.Property) &&
                          objectBase.GetClassName().Equals(objectBase.VirtualProperty) &&
                          objectBase.GetClassName().Equals(objectBase.GetString()) &&
                          objectBase.GetClassName().Equals(objectBase.GetVirtualString());
            return result;
        }
        public virtual Base Init()
        {
            return new Base();
        }
    }
    public class ChildTest : BaseTest
    {
        public override Base Init()
        {
            return new Child();
        }
    }
}
