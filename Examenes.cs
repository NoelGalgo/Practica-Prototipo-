using System;

namespace SistemaExamenesTec
{
    [cite_start]// Clase abstracta que define el contrato de clonación [cite: 56]
    public abstract class ExamenPrototype
    {
        protected string _materia;
        protected string _clave;
        protected string _docente;
        protected string _salon;
        protected string _grupo;

        [cite_start]// Propiedades para personalizar los clones [cite: 60-61]
        public string Docente { set => _docente = value; }
        public string Salon { set => _salon = value; }
        public string Grupo { set => _grupo = value; }

        public abstract ExamenPrototype Clone(); // [cite: 62]
        public abstract string VerExamen();     // [cite: 63]
    }

    // --- IMPLEMENTACIÓN DE LAS 8 MATERIAS ---

    public class ExamenPatrones : ExamenPrototype {
        public ExamenPatrones() { _materia = "Patrones de Diseño"; _clave = "SC102"; }
        public override ExamenPrototype Clone() => (ExamenPatrones)this.MemberwiseClone(); // 
        public override string VerExamen() => $"[Materia: {_materia}] Clave: {_clave} | Docente: {_docente} | Grupo: {_grupo} | Salón: {_salon}";
    }

    public class ExamenBD : ExamenPrototype {
        public ExamenBD() { _materia = "Bases de Datos"; _clave = "BD304"; }
        public override ExamenPrototype Clone() => (ExamenBD)this.MemberwiseClone();
        public override string VerExamen() => $"[Materia: {_materia}] Clave: {_clave} | Docente: {_docente} | Grupo: {_grupo} | Salón: {_salon}";
    }

    public class ExamenRedes : ExamenPrototype {
        public ExamenRedes() { _materia = "Redes de Computadoras"; _clave = "RD405"; }
        public override ExamenPrototype Clone() => (ExamenRedes)this.MemberwiseClone();
        public override string VerExamen() => $"[Materia: {_materia}] Clave: {_clave} | Docente: {_docente} | Grupo: {_grupo} | Salón: {_salon}";
    }

    public class ExamenIA : ExamenPrototype {
        public ExamenIA() { _materia = "IA"; _clave = "IA506"; }
        public override ExamenPrototype Clone() => (ExamenIA)this.MemberwiseClone();
        public override string VerExamen() => $"[Materia: {_materia}] Clave: {_clave} | Docente: {_docente} | Grupo: {_grupo} | Salón: {_salon}";
    }

    public class ExamenWeb : ExamenPrototype {
        public ExamenWeb() { _materia = "Prog. Web"; _clave = "PW607"; }
        public override ExamenPrototype Clone() => (ExamenWeb)this.MemberwiseClone();
        public override string VerExamen() => $"[Materia: {_materia}] Clave: {_clave} | Docente: {_docente} | Grupo: {_grupo} | Salón: {_salon}";
    }

    public class ExamenSistemas : ExamenPrototype {
        public ExamenSistemas() { _materia = "Sistemas Operativos"; _clave = "SO708"; }
        public override ExamenPrototype Clone() => (ExamenSistemas)this.MemberwiseClone();
        public override string VerExamen() => $"[Materia: {_materia}] Clave: {_clave} | Docente: {_docente} | Grupo: {_grupo} | Salón: {_salon}";
    }

    public class ExamenCalculo : ExamenPrototype {
        public ExamenCalculo() { _materia = "Cálculo Integral"; _clave = "MA809"; }
        public override ExamenPrototype Clone() => (ExamenCalculo)this.MemberwiseClone();
        public override string VerExamen() => $"[Materia: {_materia}] Clave: {_clave} | Docente: {_docente} | Grupo: {_grupo} | Salón: {_salon}";
    }

    public class ExamenEtica : ExamenPrototype {
        public ExamenEtica() { _materia = "Taller de Ética"; _clave = "ET900"; }
        public override ExamenPrototype Clone() => (ExamenEtica)this.MemberwiseClone();
        public override string VerExamen() => $"[Materia: {_materia}] Clave: {_clave} | Docente: {_docente} | Grupo: {_grupo} | Salón: {_salon}";
    }
}
