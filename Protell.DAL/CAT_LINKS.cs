//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Protell.DAL
{
    public partial class CAT_LINKS
    {
        #region Primitive Properties
    
        public virtual long IdLink
        {
            get;
            set;
        }
    
        public virtual string LinkUrl
        {
            get;
            set;
        }
    
        public virtual string LinkName
        {
            get;
            set;
        }
    
        public virtual bool IsActive
        {
            get;
            set;
        }
    
        public virtual bool IsModified
        {
            get;
            set;
        }
    
        public virtual long LastModifiedDate
        {
            get;
            set;
        }
    
        public virtual Nullable<long> ServerLastModifiedDate
        {
            get;
            set;
        }

        #endregion

    }
}