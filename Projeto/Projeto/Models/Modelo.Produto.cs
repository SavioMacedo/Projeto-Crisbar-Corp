﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 28/11/2017 13:42:19
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;

namespace Entidade
{
    public partial class Produto {

        public Produto()
        {
            OnCreated();
        }

        public virtual long Id
        {
            get;
            set;
        }

        public virtual string Descricao
        {
            get;
            set;
        }

        public virtual double Preco
        {
            get;
            set;
        }

        public virtual long EstoqueId
        {
            get;
            set;
        }

        public virtual Estoque Estoque
        {
            get;
            set;
        }
    
        #region Extensibility Method Definitions

        partial void OnCreated();
        
        #endregion
    }

}
