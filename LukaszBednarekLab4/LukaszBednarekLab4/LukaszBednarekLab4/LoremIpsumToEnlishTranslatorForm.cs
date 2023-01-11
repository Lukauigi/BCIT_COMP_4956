using System;
using System.Windows.Forms;
using System.Threading;
using System.Linq;

/// <summary>
/// A Windows application form which translates Lorem Ipsum text to English text.
/// 
/// The application does not do a real translation, just a simulated one to look like a translation. The application uses multiple threads with mutex to have each thread pull the right
/// character from fake English translation.
/// 
/// Author: Lukasz Bednarek
/// Source(s):
/// Date: October 5, 2022
/// </summary>
namespace LukaszBednarekLab4
{
    /// <summary>
    /// A Windows application of Lorem Ipsum to English translation.
    /// </summary>
    public partial class LoremIpsumToEnlishTranslatorForm : Form
    {
        private int sharedCharacterCounter;
        private Thread thread = null;
        private string _threadName;
        private int _progress;
        private string _translation;
        private string _threadCurrentCharacter;
        private bool _isSlowTranslate;

        private static Mutex myMutex = new Mutex(); //synchronization mutex
        public const string LoremIpsumText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque congue metus a purus dapibus posuere ac a nisi. Vestibulum in lacinia odio. " +
            "Nam id sapien blandit, aliquet ligula vel, consequat ex. Morbi tristique luctus tortor, in egestas lectus suscipit non. Sed nec dictum libero, non ornare odio. Duis nec " +
            "euismod mauris, non accumsan urna. Donec ultricies tellus vel erat accumsan bibendum. Maecenas sed consequat ipsum, et posuere magna. Integer id quam in ante ullamcorper " +
            "feugiat sed sed eros. Morbi elementum sodales ullamcorper. Donec accumsan metus ac lacus ullamcorper facilisis. Curabitur tristique aliquet erat, in lacinia massa tempus " +
            "sed. Nulla et erat leo. Integer ut justo semper, dictum sapien a, pretium leo. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. " +
            "Maecenas vel tempus elit.\r\n\r\nNulla odio lectus, ultricies vel posuere eu, finibus ac leo. Sed a volutpat quam, ac egestas nibh. Ut rhoncus mi eget fringilla fringilla. " +
            "Integer nec nulla nibh. Nam non elit vel leo tempus pellentesque id ut dui. Duis vestibulum risus nec nisl eleifend commodo. Nam molestie enim quis felis dictum, nec maximus " +
            "mi luctus. Vestibulum ac venenatis massa. Etiam condimentum erat in turpis aliquet tincidunt. Etiam id magna quam. Nullam nec suscipit eros. Suspendisse ac venenatis turpis. " +
            "Duis ac faucibus dolor, nec mattis nibh. Quisque nec iaculis nulla, hendrerit consectetur ligula. Integer porttitor, orci in suscipit facilisis, turpis nisl mattis dui, at " +
            "ultricies ante diam quis massa. Quisque vel enim non turpis molestie hendrerit.";
        // fake English translation
        public const string EnglishTranslation = "I. The Book\r\n\r\nThe place was dark and dusty and half-lost\r\nIn tangles of old alleys near the quays,\r\nReeking of " +
            "strange things brought in from the seas,\r\nAnd with queer curls of fog that west winds tossed.\r\nSmall lozenge panes, obscured by smoke and frost,\r\nJust shewed the " +
            "books, in piles like twisted trees,\r\nRotting from floor to roof—congeries\r\nOf crumbling elder lore at little cost.\r\n\r\nI entered, charmed, and from a cobwebbed " +
            "heap\r\nTook up the nearest tome and thumbed it through,\r\nTrembling at curious words that seemed to keep\r\nSome secret, monstrous if one only knew.\r\nThen, looking " +
            "for some seller old in craft,\r\nI could find nothing but a voice that laughed.\r\n\r\n\r\nII. Pursuit\r\n\r\nI held the book beneath my coat, at pains\r\nTo hide the " +
            "thing from sight in such a place;\r\nHurrying through the ancient harbor lanes\r\nWith often-turning head and nervous pace.\r\nDull, furtive windows in old tottering " +
            "brick\r\nPeered at me oddly as I hastened by,\r\nAnd thinking what they sheltered, I grew sick\r\nFor a redeeming glimpse of clean blue sky.\r\n\r\nNo one had seen me take " +
            "the thing—but still\r\nA blank laugh echoed in my whirling head,\r\nAnd I could guess what nighted worlds of ill\r\nLurked in that volume I had coveted.\r\nThe way grew " +
            "strange—the walls alike and madding—\r\nAnd far behind me, unseen feet were padding.\r\n\r\n\r\nIII. The Key\r\n\r\nI do not know what windings in the waste\r\nOf those " +
            "strange sea-lanes brought me home once more,\r\nBut on my porch I trembled, white with haste\r\nTo get inside and bolt the heavy door.\r\nI had the book that told the " +
            "hidden way\r\nAcross the void and through the space-hung screens\r\nThat hold the undimensioned worlds at bay,\r\nAnd keep lost aeons to their own demesnes.\r\n\r\nAt last " +
            "the key was mine to those vague visions\r\nOf sunset spires and twilight woods that brood\r\nDim in the gulfs beyond this earth’s precisions,\r\nLurking as memories of " +
            "infinitude.\r\nThe key was mine, but as I sat there mumbling,\r\nThe attic window shook with a faint fumbling.";
        public const int TotalThreads = 3; // additional threads opened by program
        public const int DelayTimer = 240;
        /// <summary>
        /// Appends to the English translation text box with a single character.
        /// </summary>
        public string Translation
        {
            get { return textBoxEnglishTranslation.Text; }
            set
            {
                _translation = value;
                this.textBoxEnglishTranslation.Invoke(new Action(() => this.textBoxEnglishTranslation.Text += _translation));
            }
        }
        /// <summary>
        /// Fills the progress bar as the English translation text box approaches completion.
        /// </summary>
        public int Progress
        {
            get { return progressBarTranslation.Value; }
            set
            {
                _progress = value;
                this.progressBarTranslation.Invoke(new Action(() => this.progressBarTranslation.Value = _progress));
            }
        }
        /// <summary>
        /// Property associated with the thread name displayed in text box.
        /// </summary>
        public string ThreadName
        {
            get
            {
                return _threadName;
            }

            set
            {
                _threadName = value;
                this.textBoxCurrentThread.Invoke(new Action(() => this.textBoxCurrentThread.Text = _threadName)); //change what is displayed
            }
        }
        /// <summary>
        /// Displays a thread's current character it has pulled from the translation.
        /// </summary>
        public string ThreadCurrentCharacter
        {
            get { return _threadCurrentCharacter; }
            set
            {
                _threadCurrentCharacter = value;
                this.textBoxCurrentThreadCharacter.Invoke(new Action(() => this.textBoxCurrentThreadCharacter.Text = _threadCurrentCharacter.ToString()));
            }
        }
        public bool IsSlowTranslate { get; set; }

        /// <summary>
        /// The Form of the program.
        /// </summary>
        public LoremIpsumToEnlishTranslatorForm()
        {
            InitializeComponent();
            textBoxUntranslated.Text = LoremIpsumText;
            progressBarTranslation.Maximum = EnglishTranslation.Length;
            progressBarTranslation.Visible = false;
        }

        /// <summary>
        /// Listens and triggers the fast translation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFastTranslation_Click(object sender, EventArgs e)
        {
            IsSlowTranslate = false;
            ExecuteTranslate();
        }

        /// <summary>
        /// Listens and triggers the slow translation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSlowTranslation_Click(object sender, EventArgs e)
        {
            IsSlowTranslate = true;
            ExecuteTranslate();
        }

        /// <summary>
        /// Translates the Lorem Ipsum text to the English language.
        /// </summary>
        private void ExecuteTranslate()
        {
            // make buttons non-interactable
            buttonFastTranslation.Enabled = false;
            buttonSlowTranslation.Enabled = false;
            
            progressBarTranslation.Visible = true;

            // reset values
            textBoxEnglishTranslation.Text = "";
            sharedCharacterCounter = 0;

            this.Refresh(); //redraw canvas

            for (int i = 0; i < TotalThreads; i++)
            {
                thread = new Thread(new ThreadStart(ThreadTask));
                thread.Name = "t" + i;
                thread.Start();
            }
        }

        /// <summary>
        /// Gets the character from the English translation and puts appends it to the translation's text box.
        /// </summary>
        public void ThreadTask()
        {
            try
            {
                // loop until the shareCharacterCounter meets the translation's length.
                // Encountered a problem where after a thread did not meet the loop's condition, the other 2 threads still executed one more time through the loop.
                // TotalThreads - 1 is a hack to circumvent the issue. I did not have enough time to understand how to solve the issue.
                while (sharedCharacterCounter < EnglishTranslation.Length - (TotalThreads - 1))
                {
                    myMutex.WaitOne(); // lock variables
                    ThreadName = Thread.CurrentThread.Name;

                    // assigns character string to the current translated character and translation text box properties
                    ThreadCurrentCharacter = Translation = EnglishTranslation[sharedCharacterCounter].ToString(); 
                    ++sharedCharacterCounter;
                    Progress = sharedCharacterCounter; // updates progress bar

                    if (IsSlowTranslate)
                        Thread.Sleep(DelayTimer);
                    myMutex.ReleaseMutex(); // release the shared variables
                }
            }
            catch (ThreadAbortException exc)
            {
                MessageBox.Show(exc.Message, Text);
                return;
            }
        }

        /// <summary>
        /// Closes the environment safely.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode); // close properly all threads
        }
    }
}