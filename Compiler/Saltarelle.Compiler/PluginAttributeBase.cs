﻿using System;
using ICSharpCode.NRefactory.TypeSystem;

namespace Saltarelle.Compiler {
	public abstract class PluginAttributeBase : Attribute {
		public virtual void ApplyTo(IEntity entity, IAttributeStore attributeStore) {
		}

		public virtual void ApplyTo(IAssembly assembly, IAttributeStore attributeStore) {
		}
	}
}