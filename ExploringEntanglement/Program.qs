namespace ExploringEntanglement {
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Diagnostics;
    open Microsoft.Quantum.Measurement;

    @EntryPoint()
    operation TestEntanglement1() : Result[] {
        use qubits = Qubit[2];
        H(qubits[0]);
        CNOT(qubits[0], qubits[1]);
        Message("Entangled state before measurement:");
        DumpMachine();
        Message(" ");
        let results = MultiM(qubits);
        Message("State after measurement:");
        DumpMachine();
        return results;
    }
}