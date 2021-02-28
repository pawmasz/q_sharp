//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 436
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ExploringInterference\",\"Name\":\"TestInterference1\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Core\",\"Name\":\"EntryPoint\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]}}]},\"Argument\":{\"Item1\":{\"Case\":\"UnitValue\"},\"Item2\":[],\"Item3\":{\"Case\":\"UnitType\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":12},\"Item2\":{\"Line\":1,\"Column\":14}}]}},\"Offset\":{\"Item1\":6,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\GitLab\\\\q_sharp\\\\ExploringInterference\\\\Program.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Result\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ExploringInterference\",\"Name\":\"TestInterference1\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\GitLab\\\\q_sharp\\\\ExploringInterference\\\\Program.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
#line hidden
namespace ExploringInterference
{
    [SourceLocation("C:\\GitLab\\q_sharp\\ExploringInterference\\Program.qs", OperationFunctor.Body, 8, -1)]
    public partial class TestInterference1 : Operation<QVoid, Result>, ICallable
    {
        public TestInterference1(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestInterference1";
        String ICallable.FullName => "ExploringInterference.TestInterference1";
        public static EntryPointInfo<QVoid, Result> Info => new EntryPointInfo<QVoid, Result>(typeof(TestInterference1));
        protected Allocate Allocate__
        {
            get;
            set;
        }

        protected Release Release__
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message__
        {
            get;
            set;
        }

        protected ICallable Microsoft__Quantum__Diagnostics__DumpMachine
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> Microsoft__Quantum__Measurement__MResetZ
        {
            get;
            set;
        }

        public override Func<QVoid, Result> __Body__ => (__in__) =>
        {
#line hidden
            {
#line 9 "C:\\GitLab\\q_sharp\\ExploringInterference\\Program.qs"
                var q = Allocate__.Apply();
#line hidden
                bool __arg1__ = true;
                try
                {
#line 10 "C:\\GitLab\\q_sharp\\ExploringInterference\\Program.qs"
                    Message__.Apply(" ");
#line 11 "C:\\GitLab\\q_sharp\\ExploringInterference\\Program.qs"
                    Message__.Apply("At the beginning the qubit is in the state |0>.");
#line 12 "C:\\GitLab\\q_sharp\\ExploringInterference\\Program.qs"
                    Microsoft__Quantum__Diagnostics__DumpMachine.Apply(QVoid.Instance);
#line 13 "C:\\GitLab\\q_sharp\\ExploringInterference\\Program.qs"
                    Microsoft__Quantum__Intrinsic__H.Apply(q);
#line 14 "C:\\GitLab\\q_sharp\\ExploringInterference\\Program.qs"
                    Message__.Apply(" ");
#line 15 "C:\\GitLab\\q_sharp\\ExploringInterference\\Program.qs"
                    Message__.Apply("After applying H the qubit is in a uniform superposition.");
#line 16 "C:\\GitLab\\q_sharp\\ExploringInterference\\Program.qs"
                    Microsoft__Quantum__Diagnostics__DumpMachine.Apply(QVoid.Instance);
#line 17 "C:\\GitLab\\q_sharp\\ExploringInterference\\Program.qs"
                    Microsoft__Quantum__Intrinsic__H.Apply(q);
#line 18 "C:\\GitLab\\q_sharp\\ExploringInterference\\Program.qs"
                    Message__.Apply(" ");
#line 19 "C:\\GitLab\\q_sharp\\ExploringInterference\\Program.qs"
                    Message__.Apply("If we apply H again, interference gives back the state to |0>.");
#line 20 "C:\\GitLab\\q_sharp\\ExploringInterference\\Program.qs"
                    Microsoft__Quantum__Diagnostics__DumpMachine.Apply(QVoid.Instance);
#line 21 "C:\\GitLab\\q_sharp\\ExploringInterference\\Program.qs"
                    Message__.Apply(" ");
#line 22 "C:\\GitLab\\q_sharp\\ExploringInterference\\Program.qs"
                    Message__.Apply("If we measure we always obtain 'Zero'.");
#line 23 "C:\\GitLab\\q_sharp\\ExploringInterference\\Program.qs"
                    return Microsoft__Quantum__Measurement__MResetZ.Apply(q);
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release__.Apply(q);
                    }
                }
            }
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.Message__ = this.__Factory__.Get<ICallable<String, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.Message));
            this.Microsoft__Quantum__Diagnostics__DumpMachine = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Diagnostics.DumpMachine<>));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Measurement__MResetZ = this.__Factory__.Get<ICallable<Qubit, Result>>(typeof(global::Microsoft.Quantum.Measurement.MResetZ));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__)
        {
            return __m__.Run<TestInterference1, QVoid, Result>(QVoid.Instance);
        }
    }
}