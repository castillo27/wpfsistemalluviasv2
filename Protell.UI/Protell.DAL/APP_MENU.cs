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
    public partial class APP_MENU
    {
        #region Primitive Properties
    
        public virtual long IdMenu
        {
            get;
            set;
        }
    
        public virtual string MenuName
        {
            get;
            set;
        }
    
        public virtual bool IsLeaf
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

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<APP_ROL_MENU> APP_ROL_MENU
        {
            get
            {
                if (_aPP_ROL_MENU == null)
                {
                    var newCollection = new FixupCollection<APP_ROL_MENU>();
                    newCollection.CollectionChanged += FixupAPP_ROL_MENU;
                    _aPP_ROL_MENU = newCollection;
                }
                return _aPP_ROL_MENU;
            }
            set
            {
                if (!ReferenceEquals(_aPP_ROL_MENU, value))
                {
                    var previousValue = _aPP_ROL_MENU as FixupCollection<APP_ROL_MENU>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupAPP_ROL_MENU;
                    }
                    _aPP_ROL_MENU = value;
                    var newValue = value as FixupCollection<APP_ROL_MENU>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupAPP_ROL_MENU;
                    }
                }
            }
        }
        private ICollection<APP_ROL_MENU> _aPP_ROL_MENU;

        #endregion
        #region Association Fixup
    
        private void FixupAPP_ROL_MENU(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (APP_ROL_MENU item in e.NewItems)
                {
                    item.APP_MENU = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (APP_ROL_MENU item in e.OldItems)
                {
                    if (ReferenceEquals(item.APP_MENU, this))
                    {
                        item.APP_MENU = null;
                    }
                }
            }
        }

        #endregion
    }
}