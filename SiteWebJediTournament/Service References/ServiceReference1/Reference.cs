﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiteWebJediTournament.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JediWCF", Namespace="http://schemas.datacontract.org/2004/07/JediService.BusinessWCF")]
    [System.SerializableAttribute()]
    public partial class JediWCF : SiteWebJediTournament.ServiceReference1.EntityObjectWCF {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SiteWebJediTournament.ServiceReference1.CaracteristiqueWCF[] CaracteristiquesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSithField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SiteWebJediTournament.ServiceReference1.CaracteristiqueWCF[] Caracteristiques {
            get {
                return this.CaracteristiquesField;
            }
            set {
                if ((object.ReferenceEquals(this.CaracteristiquesField, value) != true)) {
                    this.CaracteristiquesField = value;
                    this.RaisePropertyChanged("Caracteristiques");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSith {
            get {
                return this.IsSithField;
            }
            set {
                if ((this.IsSithField.Equals(value) != true)) {
                    this.IsSithField = value;
                    this.RaisePropertyChanged("IsSith");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityObjectWCF", Namespace="http://schemas.datacontract.org/2004/07/JediService.BusinessWCF")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SiteWebJediTournament.ServiceReference1.CaracteristiqueWCF))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SiteWebJediTournament.ServiceReference1.MatchWCF))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SiteWebJediTournament.ServiceReference1.StadeWCF))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SiteWebJediTournament.ServiceReference1.TournoiWCF))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SiteWebJediTournament.ServiceReference1.JediWCF))]
    public partial class EntityObjectWCF : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CaracteristiqueWCF", Namespace="http://schemas.datacontract.org/2004/07/JediService.BusinessWCF")]
    [System.SerializableAttribute()]
    public partial class CaracteristiqueWCF : SiteWebJediTournament.ServiceReference1.EntityObjectWCF {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SiteWebJediTournament.ServiceReference1.EDefCaracteristique DefinitionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SiteWebJediTournament.ServiceReference1.ETypeCaracteristique TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ValeurField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SiteWebJediTournament.ServiceReference1.EDefCaracteristique Definition {
            get {
                return this.DefinitionField;
            }
            set {
                if ((this.DefinitionField.Equals(value) != true)) {
                    this.DefinitionField = value;
                    this.RaisePropertyChanged("Definition");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SiteWebJediTournament.ServiceReference1.ETypeCaracteristique Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Valeur {
            get {
                return this.ValeurField;
            }
            set {
                if ((this.ValeurField.Equals(value) != true)) {
                    this.ValeurField = value;
                    this.RaisePropertyChanged("Valeur");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MatchWCF", Namespace="http://schemas.datacontract.org/2004/07/JediService.BusinessWCF")]
    [System.SerializableAttribute()]
    public partial class MatchWCF : SiteWebJediTournament.ServiceReference1.EntityObjectWCF {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SiteWebJediTournament.ServiceReference1.JediWCF Jedi1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SiteWebJediTournament.ServiceReference1.JediWCF Jedi2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SiteWebJediTournament.ServiceReference1.JediWCF JediVainqueurField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SiteWebJediTournament.ServiceReference1.EPhaseTournoi PhaseTournoiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SiteWebJediTournament.ServiceReference1.StadeWCF StadeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SiteWebJediTournament.ServiceReference1.JediWCF Jedi1 {
            get {
                return this.Jedi1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Jedi1Field, value) != true)) {
                    this.Jedi1Field = value;
                    this.RaisePropertyChanged("Jedi1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SiteWebJediTournament.ServiceReference1.JediWCF Jedi2 {
            get {
                return this.Jedi2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Jedi2Field, value) != true)) {
                    this.Jedi2Field = value;
                    this.RaisePropertyChanged("Jedi2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SiteWebJediTournament.ServiceReference1.JediWCF JediVainqueur {
            get {
                return this.JediVainqueurField;
            }
            set {
                if ((object.ReferenceEquals(this.JediVainqueurField, value) != true)) {
                    this.JediVainqueurField = value;
                    this.RaisePropertyChanged("JediVainqueur");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SiteWebJediTournament.ServiceReference1.EPhaseTournoi PhaseTournoi {
            get {
                return this.PhaseTournoiField;
            }
            set {
                if ((this.PhaseTournoiField.Equals(value) != true)) {
                    this.PhaseTournoiField = value;
                    this.RaisePropertyChanged("PhaseTournoi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SiteWebJediTournament.ServiceReference1.StadeWCF Stade {
            get {
                return this.StadeField;
            }
            set {
                if ((object.ReferenceEquals(this.StadeField, value) != true)) {
                    this.StadeField = value;
                    this.RaisePropertyChanged("Stade");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StadeWCF", Namespace="http://schemas.datacontract.org/2004/07/JediService.BusinessWCF")]
    [System.SerializableAttribute()]
    public partial class StadeWCF : SiteWebJediTournament.ServiceReference1.EntityObjectWCF {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SiteWebJediTournament.ServiceReference1.CaracteristiqueWCF[] CaracteristiquesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NbPlacesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlaneteField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SiteWebJediTournament.ServiceReference1.CaracteristiqueWCF[] Caracteristiques {
            get {
                return this.CaracteristiquesField;
            }
            set {
                if ((object.ReferenceEquals(this.CaracteristiquesField, value) != true)) {
                    this.CaracteristiquesField = value;
                    this.RaisePropertyChanged("Caracteristiques");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NbPlaces {
            get {
                return this.NbPlacesField;
            }
            set {
                if ((this.NbPlacesField.Equals(value) != true)) {
                    this.NbPlacesField = value;
                    this.RaisePropertyChanged("NbPlaces");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Planete {
            get {
                return this.PlaneteField;
            }
            set {
                if ((object.ReferenceEquals(this.PlaneteField, value) != true)) {
                    this.PlaneteField = value;
                    this.RaisePropertyChanged("Planete");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TournoiWCF", Namespace="http://schemas.datacontract.org/2004/07/JediService.BusinessWCF")]
    [System.SerializableAttribute()]
    public partial class TournoiWCF : SiteWebJediTournament.ServiceReference1.EntityObjectWCF {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SiteWebJediTournament.ServiceReference1.MatchWCF[] MatchesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SiteWebJediTournament.ServiceReference1.MatchWCF[] Matches {
            get {
                return this.MatchesField;
            }
            set {
                if ((object.ReferenceEquals(this.MatchesField, value) != true)) {
                    this.MatchesField = value;
                    this.RaisePropertyChanged("Matches");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EDefCaracteristique", Namespace="http://schemas.datacontract.org/2004/07/EntitiesLayer")]
    public enum EDefCaracteristique : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Force = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Defense = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Chance = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Sante = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ETypeCaracteristique", Namespace="http://schemas.datacontract.org/2004/07/EntitiesLayer")]
    public enum ETypeCaracteristique : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Jedi = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Stade = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EPhaseTournoi", Namespace="http://schemas.datacontract.org/2004/07/EntitiesLayer")]
    public enum EPhaseTournoi : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        QuartFinale = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        HuitiemeFinale = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DemiFinale = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Finale = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IServiceJedi")]
    public interface IServiceJedi {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/getAllJedi", ReplyAction="http://tempuri.org/IServiceJedi/getAllJediResponse")]
        SiteWebJediTournament.ServiceReference1.JediWCF[] getAllJedi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/getAllJedi", ReplyAction="http://tempuri.org/IServiceJedi/getAllJediResponse")]
        System.Threading.Tasks.Task<SiteWebJediTournament.ServiceReference1.JediWCF[]> getAllJediAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/getAllMatch", ReplyAction="http://tempuri.org/IServiceJedi/getAllMatchResponse")]
        SiteWebJediTournament.ServiceReference1.MatchWCF[] getAllMatch();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/getAllMatch", ReplyAction="http://tempuri.org/IServiceJedi/getAllMatchResponse")]
        System.Threading.Tasks.Task<SiteWebJediTournament.ServiceReference1.MatchWCF[]> getAllMatchAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/getAllStade", ReplyAction="http://tempuri.org/IServiceJedi/getAllStadeResponse")]
        SiteWebJediTournament.ServiceReference1.StadeWCF[] getAllStade();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/getAllStade", ReplyAction="http://tempuri.org/IServiceJedi/getAllStadeResponse")]
        System.Threading.Tasks.Task<SiteWebJediTournament.ServiceReference1.StadeWCF[]> getAllStadeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/getAllTournoi", ReplyAction="http://tempuri.org/IServiceJedi/getAllTournoiResponse")]
        SiteWebJediTournament.ServiceReference1.TournoiWCF[] getAllTournoi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/getAllTournoi", ReplyAction="http://tempuri.org/IServiceJedi/getAllTournoiResponse")]
        System.Threading.Tasks.Task<SiteWebJediTournament.ServiceReference1.TournoiWCF[]> getAllTournoiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/getAllCaracteristique", ReplyAction="http://tempuri.org/IServiceJedi/getAllCaracteristiqueResponse")]
        SiteWebJediTournament.ServiceReference1.CaracteristiqueWCF[] getAllCaracteristique();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/getAllCaracteristique", ReplyAction="http://tempuri.org/IServiceJedi/getAllCaracteristiqueResponse")]
        System.Threading.Tasks.Task<SiteWebJediTournament.ServiceReference1.CaracteristiqueWCF[]> getAllCaracteristiqueAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/addJedi", ReplyAction="http://tempuri.org/IServiceJedi/addJediResponse")]
        void addJedi(SiteWebJediTournament.ServiceReference1.JediWCF jedi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/addJedi", ReplyAction="http://tempuri.org/IServiceJedi/addJediResponse")]
        System.Threading.Tasks.Task addJediAsync(SiteWebJediTournament.ServiceReference1.JediWCF jedi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/addMatch", ReplyAction="http://tempuri.org/IServiceJedi/addMatchResponse")]
        void addMatch(SiteWebJediTournament.ServiceReference1.MatchWCF match);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/addMatch", ReplyAction="http://tempuri.org/IServiceJedi/addMatchResponse")]
        System.Threading.Tasks.Task addMatchAsync(SiteWebJediTournament.ServiceReference1.MatchWCF match);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/addStade", ReplyAction="http://tempuri.org/IServiceJedi/addStadeResponse")]
        void addStade(SiteWebJediTournament.ServiceReference1.StadeWCF stade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/addStade", ReplyAction="http://tempuri.org/IServiceJedi/addStadeResponse")]
        System.Threading.Tasks.Task addStadeAsync(SiteWebJediTournament.ServiceReference1.StadeWCF stade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/addTournoi", ReplyAction="http://tempuri.org/IServiceJedi/addTournoiResponse")]
        void addTournoi(SiteWebJediTournament.ServiceReference1.TournoiWCF tournoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/addTournoi", ReplyAction="http://tempuri.org/IServiceJedi/addTournoiResponse")]
        System.Threading.Tasks.Task addTournoiAsync(SiteWebJediTournament.ServiceReference1.TournoiWCF tournoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/addCracteristique", ReplyAction="http://tempuri.org/IServiceJedi/addCracteristiqueResponse")]
        void addCracteristique(SiteWebJediTournament.ServiceReference1.CaracteristiqueWCF caract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/addCracteristique", ReplyAction="http://tempuri.org/IServiceJedi/addCracteristiqueResponse")]
        System.Threading.Tasks.Task addCracteristiqueAsync(SiteWebJediTournament.ServiceReference1.CaracteristiqueWCF caract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/deleteJedi", ReplyAction="http://tempuri.org/IServiceJedi/deleteJediResponse")]
        void deleteJedi(SiteWebJediTournament.ServiceReference1.JediWCF jedi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/deleteJedi", ReplyAction="http://tempuri.org/IServiceJedi/deleteJediResponse")]
        System.Threading.Tasks.Task deleteJediAsync(SiteWebJediTournament.ServiceReference1.JediWCF jedi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/deleteMatch", ReplyAction="http://tempuri.org/IServiceJedi/deleteMatchResponse")]
        void deleteMatch(SiteWebJediTournament.ServiceReference1.MatchWCF match);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/deleteMatch", ReplyAction="http://tempuri.org/IServiceJedi/deleteMatchResponse")]
        System.Threading.Tasks.Task deleteMatchAsync(SiteWebJediTournament.ServiceReference1.MatchWCF match);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/deleteStade", ReplyAction="http://tempuri.org/IServiceJedi/deleteStadeResponse")]
        void deleteStade(SiteWebJediTournament.ServiceReference1.StadeWCF stade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/deleteStade", ReplyAction="http://tempuri.org/IServiceJedi/deleteStadeResponse")]
        System.Threading.Tasks.Task deleteStadeAsync(SiteWebJediTournament.ServiceReference1.StadeWCF stade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/deleteTournois", ReplyAction="http://tempuri.org/IServiceJedi/deleteTournoisResponse")]
        void deleteTournois(SiteWebJediTournament.ServiceReference1.TournoiWCF tournoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/deleteTournois", ReplyAction="http://tempuri.org/IServiceJedi/deleteTournoisResponse")]
        System.Threading.Tasks.Task deleteTournoisAsync(SiteWebJediTournament.ServiceReference1.TournoiWCF tournoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/deleteCaracteristique", ReplyAction="http://tempuri.org/IServiceJedi/deleteCaracteristiqueResponse")]
        void deleteCaracteristique(SiteWebJediTournament.ServiceReference1.CaracteristiqueWCF caract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/deleteCaracteristique", ReplyAction="http://tempuri.org/IServiceJedi/deleteCaracteristiqueResponse")]
        System.Threading.Tasks.Task deleteCaracteristiqueAsync(SiteWebJediTournament.ServiceReference1.CaracteristiqueWCF caract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/updateJedi", ReplyAction="http://tempuri.org/IServiceJedi/updateJediResponse")]
        void updateJedi(SiteWebJediTournament.ServiceReference1.JediWCF jedi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/updateJedi", ReplyAction="http://tempuri.org/IServiceJedi/updateJediResponse")]
        System.Threading.Tasks.Task updateJediAsync(SiteWebJediTournament.ServiceReference1.JediWCF jedi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/updateMatch", ReplyAction="http://tempuri.org/IServiceJedi/updateMatchResponse")]
        void updateMatch(SiteWebJediTournament.ServiceReference1.MatchWCF match);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/updateMatch", ReplyAction="http://tempuri.org/IServiceJedi/updateMatchResponse")]
        System.Threading.Tasks.Task updateMatchAsync(SiteWebJediTournament.ServiceReference1.MatchWCF match);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/updateStade", ReplyAction="http://tempuri.org/IServiceJedi/updateStadeResponse")]
        void updateStade(SiteWebJediTournament.ServiceReference1.StadeWCF stade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/updateStade", ReplyAction="http://tempuri.org/IServiceJedi/updateStadeResponse")]
        System.Threading.Tasks.Task updateStadeAsync(SiteWebJediTournament.ServiceReference1.StadeWCF stade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/updateTournois", ReplyAction="http://tempuri.org/IServiceJedi/updateTournoisResponse")]
        void updateTournois(SiteWebJediTournament.ServiceReference1.TournoiWCF tournoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/updateTournois", ReplyAction="http://tempuri.org/IServiceJedi/updateTournoisResponse")]
        System.Threading.Tasks.Task updateTournoisAsync(SiteWebJediTournament.ServiceReference1.TournoiWCF tournoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/updateCaracteristique", ReplyAction="http://tempuri.org/IServiceJedi/updateCaracteristiqueResponse")]
        void updateCaracteristique(SiteWebJediTournament.ServiceReference1.CaracteristiqueWCF caract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/updateCaracteristique", ReplyAction="http://tempuri.org/IServiceJedi/updateCaracteristiqueResponse")]
        System.Threading.Tasks.Task updateCaracteristiqueAsync(SiteWebJediTournament.ServiceReference1.CaracteristiqueWCF caract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/playTournoi", ReplyAction="http://tempuri.org/IServiceJedi/playTournoiResponse")]
        SiteWebJediTournament.ServiceReference1.TournoiWCF playTournoi(SiteWebJediTournament.ServiceReference1.TournoiWCF tournoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceJedi/playTournoi", ReplyAction="http://tempuri.org/IServiceJedi/playTournoiResponse")]
        System.Threading.Tasks.Task<SiteWebJediTournament.ServiceReference1.TournoiWCF> playTournoiAsync(SiteWebJediTournament.ServiceReference1.TournoiWCF tournoi);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceJediChannel : SiteWebJediTournament.ServiceReference1.IServiceJedi, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceJediClient : System.ServiceModel.ClientBase<SiteWebJediTournament.ServiceReference1.IServiceJedi>, SiteWebJediTournament.ServiceReference1.IServiceJedi {
        
        public ServiceJediClient() {
        }
        
        public ServiceJediClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceJediClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceJediClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceJediClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SiteWebJediTournament.ServiceReference1.JediWCF[] getAllJedi() {
            return base.Channel.getAllJedi();
        }
        
        public System.Threading.Tasks.Task<SiteWebJediTournament.ServiceReference1.JediWCF[]> getAllJediAsync() {
            return base.Channel.getAllJediAsync();
        }
        
        public SiteWebJediTournament.ServiceReference1.MatchWCF[] getAllMatch() {
            return base.Channel.getAllMatch();
        }
        
        public System.Threading.Tasks.Task<SiteWebJediTournament.ServiceReference1.MatchWCF[]> getAllMatchAsync() {
            return base.Channel.getAllMatchAsync();
        }
        
        public SiteWebJediTournament.ServiceReference1.StadeWCF[] getAllStade() {
            return base.Channel.getAllStade();
        }
        
        public System.Threading.Tasks.Task<SiteWebJediTournament.ServiceReference1.StadeWCF[]> getAllStadeAsync() {
            return base.Channel.getAllStadeAsync();
        }
        
        public SiteWebJediTournament.ServiceReference1.TournoiWCF[] getAllTournoi() {
            return base.Channel.getAllTournoi();
        }
        
        public System.Threading.Tasks.Task<SiteWebJediTournament.ServiceReference1.TournoiWCF[]> getAllTournoiAsync() {
            return base.Channel.getAllTournoiAsync();
        }
        
        public SiteWebJediTournament.ServiceReference1.CaracteristiqueWCF[] getAllCaracteristique() {
            return base.Channel.getAllCaracteristique();
        }
        
        public System.Threading.Tasks.Task<SiteWebJediTournament.ServiceReference1.CaracteristiqueWCF[]> getAllCaracteristiqueAsync() {
            return base.Channel.getAllCaracteristiqueAsync();
        }
        
        public void addJedi(SiteWebJediTournament.ServiceReference1.JediWCF jedi) {
            base.Channel.addJedi(jedi);
        }
        
        public System.Threading.Tasks.Task addJediAsync(SiteWebJediTournament.ServiceReference1.JediWCF jedi) {
            return base.Channel.addJediAsync(jedi);
        }
        
        public void addMatch(SiteWebJediTournament.ServiceReference1.MatchWCF match) {
            base.Channel.addMatch(match);
        }
        
        public System.Threading.Tasks.Task addMatchAsync(SiteWebJediTournament.ServiceReference1.MatchWCF match) {
            return base.Channel.addMatchAsync(match);
        }
        
        public void addStade(SiteWebJediTournament.ServiceReference1.StadeWCF stade) {
            base.Channel.addStade(stade);
        }
        
        public System.Threading.Tasks.Task addStadeAsync(SiteWebJediTournament.ServiceReference1.StadeWCF stade) {
            return base.Channel.addStadeAsync(stade);
        }
        
        public void addTournoi(SiteWebJediTournament.ServiceReference1.TournoiWCF tournoi) {
            base.Channel.addTournoi(tournoi);
        }
        
        public System.Threading.Tasks.Task addTournoiAsync(SiteWebJediTournament.ServiceReference1.TournoiWCF tournoi) {
            return base.Channel.addTournoiAsync(tournoi);
        }
        
        public void addCracteristique(SiteWebJediTournament.ServiceReference1.CaracteristiqueWCF caract) {
            base.Channel.addCracteristique(caract);
        }
        
        public System.Threading.Tasks.Task addCracteristiqueAsync(SiteWebJediTournament.ServiceReference1.CaracteristiqueWCF caract) {
            return base.Channel.addCracteristiqueAsync(caract);
        }
        
        public void deleteJedi(SiteWebJediTournament.ServiceReference1.JediWCF jedi) {
            base.Channel.deleteJedi(jedi);
        }
        
        public System.Threading.Tasks.Task deleteJediAsync(SiteWebJediTournament.ServiceReference1.JediWCF jedi) {
            return base.Channel.deleteJediAsync(jedi);
        }
        
        public void deleteMatch(SiteWebJediTournament.ServiceReference1.MatchWCF match) {
            base.Channel.deleteMatch(match);
        }
        
        public System.Threading.Tasks.Task deleteMatchAsync(SiteWebJediTournament.ServiceReference1.MatchWCF match) {
            return base.Channel.deleteMatchAsync(match);
        }
        
        public void deleteStade(SiteWebJediTournament.ServiceReference1.StadeWCF stade) {
            base.Channel.deleteStade(stade);
        }
        
        public System.Threading.Tasks.Task deleteStadeAsync(SiteWebJediTournament.ServiceReference1.StadeWCF stade) {
            return base.Channel.deleteStadeAsync(stade);
        }
        
        public void deleteTournois(SiteWebJediTournament.ServiceReference1.TournoiWCF tournoi) {
            base.Channel.deleteTournois(tournoi);
        }
        
        public System.Threading.Tasks.Task deleteTournoisAsync(SiteWebJediTournament.ServiceReference1.TournoiWCF tournoi) {
            return base.Channel.deleteTournoisAsync(tournoi);
        }
        
        public void deleteCaracteristique(SiteWebJediTournament.ServiceReference1.CaracteristiqueWCF caract) {
            base.Channel.deleteCaracteristique(caract);
        }
        
        public System.Threading.Tasks.Task deleteCaracteristiqueAsync(SiteWebJediTournament.ServiceReference1.CaracteristiqueWCF caract) {
            return base.Channel.deleteCaracteristiqueAsync(caract);
        }
        
        public void updateJedi(SiteWebJediTournament.ServiceReference1.JediWCF jedi) {
            base.Channel.updateJedi(jedi);
        }
        
        public System.Threading.Tasks.Task updateJediAsync(SiteWebJediTournament.ServiceReference1.JediWCF jedi) {
            return base.Channel.updateJediAsync(jedi);
        }
        
        public void updateMatch(SiteWebJediTournament.ServiceReference1.MatchWCF match) {
            base.Channel.updateMatch(match);
        }
        
        public System.Threading.Tasks.Task updateMatchAsync(SiteWebJediTournament.ServiceReference1.MatchWCF match) {
            return base.Channel.updateMatchAsync(match);
        }
        
        public void updateStade(SiteWebJediTournament.ServiceReference1.StadeWCF stade) {
            base.Channel.updateStade(stade);
        }
        
        public System.Threading.Tasks.Task updateStadeAsync(SiteWebJediTournament.ServiceReference1.StadeWCF stade) {
            return base.Channel.updateStadeAsync(stade);
        }
        
        public void updateTournois(SiteWebJediTournament.ServiceReference1.TournoiWCF tournoi) {
            base.Channel.updateTournois(tournoi);
        }
        
        public System.Threading.Tasks.Task updateTournoisAsync(SiteWebJediTournament.ServiceReference1.TournoiWCF tournoi) {
            return base.Channel.updateTournoisAsync(tournoi);
        }
        
        public void updateCaracteristique(SiteWebJediTournament.ServiceReference1.CaracteristiqueWCF caract) {
            base.Channel.updateCaracteristique(caract);
        }
        
        public System.Threading.Tasks.Task updateCaracteristiqueAsync(SiteWebJediTournament.ServiceReference1.CaracteristiqueWCF caract) {
            return base.Channel.updateCaracteristiqueAsync(caract);
        }
        
        public SiteWebJediTournament.ServiceReference1.TournoiWCF playTournoi(SiteWebJediTournament.ServiceReference1.TournoiWCF tournoi) {
            return base.Channel.playTournoi(tournoi);
        }
        
        public System.Threading.Tasks.Task<SiteWebJediTournament.ServiceReference1.TournoiWCF> playTournoiAsync(SiteWebJediTournament.ServiceReference1.TournoiWCF tournoi) {
            return base.Channel.playTournoiAsync(tournoi);
        }
    }
}
