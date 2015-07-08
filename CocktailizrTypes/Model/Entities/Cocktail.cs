﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization;
using CocktailizrTypes.Helper.Serializer;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Options;

namespace CocktailizrTypes.Model.Entities
{
    [DataContract]
    [BsonIgnoreExtraElements]
    public class Cocktail : CocktailizrEntityBase
    {
        private string _name;


        [DataMember]
        [BsonElement]
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private IEnumerable<string> _tags;
        [DataMember]
        [BsonElement]
        public IEnumerable<string> Tags
        {
            get { return _tags; }
            set
            {
                _tags = value;
                OnPropertyChanged();
            }
        }

        private Color _drinkColor;

        [DataMember]
        [BsonElement, BsonSerializer(typeof(ColorBsonSerializer))]
        public Color DrinkColor
        {
            get { return _drinkColor; }
            set
            {
                _drinkColor = value;
                OnPropertyChanged();
            }
        }

        private bool _alcoholic;

        [DataMember]
        [BsonElement]
        public bool Alcoholic
        {
            get { return _alcoholic; }
            set
            {
                _alcoholic = value;
                OnPropertyChanged();
            }
        }

        private IDictionary<Zutat, decimal> _zutaten;

        [DataMember]
        [BsonElement, BsonDictionaryOptions(DictionaryRepresentation.ArrayOfDocuments)]
        public IDictionary<Zutat, decimal> Zutaten
        {
            get { return _zutaten; }
            set
            {
                _zutaten = value;
                OnPropertyChanged();
            }
        }

        private Rezept _rezept;

        [DataMember]
        [BsonElement]
        public Rezept Rezept
        {
            get { return _rezept; }
            set
            {
                _rezept = value;
                OnPropertyChanged();
            }
        }

        [DataMember]
        [BsonElement]
        public byte[] ImageBytes { get; set; }

        [BsonIgnore]
        public Image Image
        {
            get
            {
                if (ImageBytes == null) { return null; }
                var ms = new MemoryStream(ImageBytes);
                return ms.Length > 0 ? new Bitmap(ms) : null;

            }
            set
            {
                if (value == null)
                {
                    ImageBytes = new byte[] { };
                    return;
                }
                using (var ms = new MemoryStream())
                {
                    value.Save(ms, ImageFormat.Bmp);
                    ImageBytes = ms.ToArray();
                }
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }

    [DataContract]
    [BsonIgnoreExtraElements]
    public class Rezept
    {
        [DataMember]
        [BsonElement]
        public TimeSpan Zubereitungszeit { get; set; }

        [DataMember]
        [BsonElement]
        public IEnumerable<Step> ZubereitungsSchritte { get; set; }

    }

    [DataContract]
    [BsonIgnoreExtraElements]
    public class Step
    {
        [DataMember]
        [BsonElement]
        public string Beschreibung { get; set; }

        [DataMember]
        [BsonElement]
        public string Headline { get; set; }

    }

    [DataContract]
    [BsonIgnoreExtraElements]
    public class Zutat
    {
        [DataMember]
        [BsonElement]
        public string Name { get; set; }

        [DataMember]
        [BsonElement]
        public bool IsOptional { get; set; }

        [DataMember]
        [BsonElement, BsonRepresentation(BsonType.String)]
        public ZutatenSkala Skala { get; set; }

        [BsonIgnore]
        public bool IsSelected { get; set; }

        public override bool Equals(Object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Point return false.
            Zutat p = obj as Zutat;
            if (p == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (p.GetHashCode() == GetHashCode());
        }

        public bool Equals(Zutat p)
        {
            // If parameter is null return false:
            if (p == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (p.GetHashCode() == GetHashCode());
        }

        public override int GetHashCode()
        {
            var hash = Name.GetHashCode() * 17;
            hash += Skala.GetHashCode() * 17;
            return hash;
        }
    }

    [DataContract]
    public enum ZutatenSkala
    {
        [EnumMember]
        Cl,
        [EnumMember]
        Liter,
        [EnumMember]
        Stueck,
        [EnumMember]
        Gramm,
        [EnumMember]
        Priese,
    }
}
