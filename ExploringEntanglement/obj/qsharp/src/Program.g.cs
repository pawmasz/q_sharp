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

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ExploringEntanglement\",\"Name\":\"TestEntanglement1\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Core\",\"Name\":\"EntryPoint\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]}}]},\"Argument\":{\"Item1\":{\"Case\":\"UnitValue\"},\"Item2\":[],\"Item3\":{\"Case\":\"UnitType\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":12},\"Item2\":{\"Line\":1,\"Column\":14}}]}},\"Offset\":{\"Item1\":6,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\GitLab\\\\q_sharp\\\\ExploringEntanglement\\\\Program.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ExploringEntanglement\",\"Name\":\"TestEntanglement1\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\GitLab\\\\q_sharp\\\\ExploringEntanglement\\\\Program.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
#line hidden
namespace ExploringEntanglement
{
    [SourceLocation("C:\\GitLab\\q_sharp\\ExploringEntanglement\\Program.qs", OperationFunctor.Body, 8, -1)]
    public partial class TestEntanglement1 : Operation<QVoid, IQArray<Result>>, ICallable
    {
        public TestEntanglement1(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestEntanglement1";
        String ICallable.FullName => "ExploringEntanglement.TestEntanglement1";
        public static EntryPointInfo<QVoid, IQArray<Result>> Info => new EntryPointInfo<QVoid, IQArray<Result>>(typeof(TestEntanglement1));
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

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> Microsoft__Quantum__Intrinsic__CNOT
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

        protected ICallable<IQArray<Qubit>, IQArray<Result>> Microsoft__Quantum__Measurement__MultiM
        {
            get;
            set;
        }

        public override Func<QVoid, IQArray<Result>> __Body__ => (__in__) =>
        {
#line hidden
            {
#line 9 "C:\\GitLab\\q_sharp\\ExploringEntanglement\\Program.qs"
                var qubits = Allocate__.Apply(2L);
#line hidden
                bool __arg1__ = true;
                try
                {
#line 10 "C:\\GitLab\\q_sharp\\ExploringEntanglement\\Program.qs"
                    Microsoft__Quantum__Intrinsic__H.Apply(qubits[0L]);
#line 11 "C:\\GitLab\\q_sharp\\ExploringEntanglement\\Program.qs"
                    Microsoft__Quantum__Intrinsic__CNOT.Apply((qubits[0L], qubits[1L]));
#line 12 "C:\\GitLab\\q_sharp\\ExploringEntanglement\\Program.qs"
                    Message__.Apply("Entangled state before measurement:");
#line 13 "C:\\GitLab\\q_sharp\\ExploringEntanglement\\Program.qs"
                    Microsoft__Quantum__Diagnostics__DumpMachine.Apply(QVoid.Instance);
#line 14 "C:\\GitLab\\q_sharp\\ExploringEntanglement\\Program.qs"
                    Message__.Apply(" ");
#line 15 "C:\\GitLab\\q_sharp\\ExploringEntanglement\\Program.qs"
                    var results = (IQArray<Result>)Microsoft__Quantum__Measurement__MultiM.Apply(qubits);
#line 16 "C:\\GitLab\\q_sharp\\ExploringEntanglement\\Program.qs"
                    Message__.Apply("State after measurement:");
#line 17 "C:\\GitLab\\q_sharp\\ExploringEntanglement\\Program.qs"
                    Microsoft__Quantum__Diagnostics__DumpMachine.Apply(QVoid.Instance);
#line 18 "C:\\GitLab\\q_sharp\\ExploringEntanglement\\Program.qs"
                    return results;
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
                        Release__.Apply(qubits);
                    }
                }
            }
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Intrinsic__CNOT = this.__Factory__.Get<IUnitary<(Qubit,Qubit)>>(typeof(global::Microsoft.Quantum.Intrinsic.CNOT));
            this.Message__ = this.__Factory__.Get<ICallable<String, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.Message));
            this.Microsoft__Quantum__Diagnostics__DumpMachine = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Diagnostics.DumpMachine<>));
            this.Microsoft__Quantum__Measurement__MultiM = this.__Factory__.Get<ICallable<IQArray<Qubit>, IQArray<Result>>>(typeof(global::Microsoft.Quantum.Measurement.MultiM));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(IQArray<Result> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Result>> Run(IOperationFactory __m__)
        {
            return __m__.Run<TestEntanglement1, QVoid, IQArray<Result>>(QVoid.Instance);
        }
    }
}