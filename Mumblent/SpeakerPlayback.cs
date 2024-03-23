using NAudio.Wave;

namespace Mumblent;

public class SpeakerPlayback
    {
        private static int _selectedDevice = -1;
        public static int SelectedDevice {
            get { return _selectedDevice; }
            set {
                _selectedDevice = value;
                foreach(var player in _players)
                {
                    player.Value.ChangeDevice();
                }
            }
        }
        private static readonly Dictionary<uint, Player> _players = new Dictionary<uint, Player>();

        public static void AddPlayer(uint id, IWaveProvider provider)
        {
            if (!_players.ContainsKey(id))
                _players.Add(id, new Player(provider));
        }

        public static void RemovePlayer(uint id)
        {
            if(_players.ContainsKey(id))
                _players[id].Dispose();
            _players.Remove(id);
        }

        public static void Play(uint id)
        {
            if (_players.ContainsKey(id))
                _players[id].Play();
        }

        public static void Stop(uint id)
        {
            if (_players.ContainsKey(id))
                _players[id].Stop();
        }

        public static void Pause(uint id)
        {
            if (_players.ContainsKey(id))
                _players[id].Pause();
        }

        private class Player : IDisposable
        {
            private NAudio.Wave.DirectSoundOut _waveOut;
            private readonly NAudio.Wave.IWaveProvider _provider;

            public Player(NAudio.Wave.IWaveProvider provider)
            {
                _provider = provider;
                _waveOut = new NAudio.Wave.DirectSoundOut();
                _waveOut.Init(_provider);
                Play();
            }

            public void Dispose()
            {
                Stop();
                _waveOut.Dispose();
            }

            public void Stop()
            {
                if (_waveOut.PlaybackState != PlaybackState.Stopped)
                    _waveOut.Stop();
            }

            public void Play()
            {
                if (_waveOut.PlaybackState != PlaybackState.Playing)
                    _waveOut.Play();
            }

            public void Pause()
            {
                if(_waveOut.PlaybackState == PlaybackState.Playing)
                    _waveOut.Pause();
            }

            public void ChangeDevice()
            {
                var state = _waveOut.PlaybackState;

                _waveOut.Dispose();
                _waveOut = new DirectSoundOut();
                _waveOut.Init(_provider);

                switch (state)
                {
                    case PlaybackState.Paused: Pause(); break;
                    case PlaybackState.Playing: Play(); break;
                }
            }

        }


    }