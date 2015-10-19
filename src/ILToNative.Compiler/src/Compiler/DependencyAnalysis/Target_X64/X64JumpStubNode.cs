﻿using ILToNative.DependencyAnalysis;
using ILToNative.DependencyAnalysis.X64;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILToNative.DependencyAnalysis
{
    /// <summary>
    /// X64 specific portions of JumpStubNode
    /// </summary>
    public partial class JumpStubNode
    {
        protected override void EmitCode(NodeFactory factory, ref X64Emitter encoder, bool relocsOnly)
        {
            encoder.EmitJMP(_target);   
        }
    }
}