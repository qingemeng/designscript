using System.Collections.Generic;

namespace ProtoCore
{
	public abstract class Executive
	{
        //protected Core core; 
        protected ProtoLanguage.CompileStateTracker compilerState;

        public Executive(ProtoLanguage.CompileStateTracker compilerState)
		{
            System.Diagnostics.Debug.Assert(compilerState != null);
            this.compilerState = compilerState;
		}

        public ProtoCore.DSASM.Executive CurrentDSASMExec { get; set; }
        public abstract bool Compile(out int blockId, ProtoCore.DSASM.CodeBlock parentBlock, ProtoCore.LanguageCodeBlock codeblock, ProtoCore.CompileTime.Context callContext, ProtoCore.DebugServices.EventSink sink = null, ProtoCore.AST.Node codeBlockNode = null, ProtoCore.AssociativeGraph.GraphNode graphNode = null);
        public abstract ProtoCore.DSASM.StackValue Execute(int codeblock, int entry, ProtoCore.Runtime.Context callContext, ProtoCore.DebugServices.EventSink sink = null);
        public abstract ProtoCore.DSASM.StackValue Execute(int codeblock, int entry, ProtoCore.Runtime.Context callContext, List<ProtoCore.DSASM.Instruction> breakpoints, ProtoCore.DebugServices.EventSink sink = null, bool fepRun = false);

	}
}

 