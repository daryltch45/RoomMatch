using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RoomMatch.Domain.Utilities
{
    public abstract class NotifyObject : INotifyPropertyChanged
    {

        private readonly Dictionary<string, object> propertyValues;

        protected NotifyObject()
        {
            propertyValues = new Dictionary<string, object>();
        }

        protected virtual void Set<T>(T value, [CallerMemberName] string propertyName = null)
        {
            if (propertyValues.ContainsKey(propertyName))
            {
                //Nur ändern, wenn es auch tatsächlich eine Änderung gab, bei null sollte der Wert danach immer von einer Value überschrieben werden
                if (propertyValues[propertyName] == null || !propertyValues[propertyName].Equals(value))
                {
                    propertyValues[propertyName] = value;
                }
            }
            else
            {
                propertyValues.Add(propertyName, value);
            }
            OnPropertyChanged(propertyName);
        }

        protected T Get<T>([CallerMemberName] string propertyName = null)
        {
            if (propertyValues.ContainsKey(propertyName))
            {
                return (T)propertyValues[propertyName];
            }
            return default;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
