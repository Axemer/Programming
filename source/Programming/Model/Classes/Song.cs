using System;

namespace Programming.Model.Classes
{
	public class Song
	{
		/// <summary>
		/// Длительность.
		/// </summary>
		private int _duration;

		/// <summary>
		/// Возвращает и задаёт длительность в секундах. Только положительные значения.
		/// </summary>
		public int Duration
        {
			get 
			{ 
				return _duration; 
			}

            set
            {
				Validator.AssertOnPositiveValue(nameof(_duration), value);
				_duration = value;
			}
        }

		/// <summary>
		/// Название трека.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Исполнитель.
		/// </summary>
		public string Artist { get; set; }

		/// <summary>
		/// Название альбома.
		/// </summary>
		public string Album { get; set; }

		/// <summary>
		/// Создаёт экземпляр класса <see cref="Song"/>
		/// </summary>
		/// <param name="title">Название трека.</param>
		/// <param name="duration">Длительность в секундах. Только положительные значения.</param>
		/// <param name="album">Название альбома.</param>
		/// <param name="artist">Исполнитель.</param>
		public Song(string title, string artist, string album, int duration)
        {
			Title = title;
			Artist = artist;
			Album = album;
			Duration = duration;
        }
	}
}

