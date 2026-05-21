using System.Diagnostics;

namespace OOPlab31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProcesses();
        }

        private void LoadProcesses()
        {
            listBox1.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (Process proc in processes)
            {
                listBox1.Items.Add($"ID: {proc.Id}  |  {proc.ProcessName}");
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadProcesses();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                {
                    foreach (var item in listBox1.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }
                MessageBox.Show("Список процесів успішно експортовано!", "Експорт",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Оберіть процес зі списку!", "Увага",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = GetSelectedProcessId();
            try
            {
                Process proc = Process.GetProcessById(id);
                string info = $"Ім'я процесу: {proc.ProcessName}\n" +
                              $"ID: {proc.Id}\n" +
                              $"Час запуску: {proc.StartTime}\n" +
                              $"Робоча пам'ять: {proc.WorkingSet64 / 1024 / 1024} МБ\n" +
                              $"Кількість потоків: {proc.Threads.Count}";
                MessageBox.Show(info, "Інформація про процес",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося отримати інформацію: " + ex.Message,
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void killToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Оберіть процес зі списку!", "Увага",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = GetSelectedProcessId();
            try
            {
                Process proc = Process.GetProcessById(id);
                DialogResult result = MessageBox.Show(
                    $"Ви дійсно хочете зупинити процес \"{proc.ProcessName}\" (ID: {proc.Id})?",
                    "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    proc.Kill();
                    LoadProcesses();
                    MessageBox.Show("Процес зупинено!", "Успіх",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося зупинити процес: " + ex.Message,
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void threadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Оберіть процес зі списку!", "Увага",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = GetSelectedProcessId();
            try
            {
                Process proc = Process.GetProcessById(id);
                ProcessThreadCollection threads = proc.Threads;
                string info = $"Потоки процесу \"{proc.ProcessName}\" (ID: {proc.Id}):\n\n";
                foreach (ProcessThread thread in threads)
                {
                    info += $"ThreadId: {thread.Id}  Пріоритет: {thread.CurrentPriority}\n";
                }
                MessageBox.Show(info, "Потоки процесу",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося отримати потоки: " + ex.Message,
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Оберіть процес зі списку!", "Увага",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = GetSelectedProcessId();
            try
            {
                Process proc = Process.GetProcessById(id);
                ProcessModuleCollection modules = proc.Modules;
                string info = $"Модулі процесу \"{proc.ProcessName}\" (ID: {proc.Id}):\n\n";
                foreach (ProcessModule module in modules)
                {
                    info += $"Name: {module.ModuleName}  FileName: {module.FileName}\n";
                }
                MessageBox.Show(info, "Модулі процесу",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося отримати модулі: " + ex.Message,
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSelectedProcessId()
        {
            string? selected = listBox1.SelectedItem?.ToString();
            string idStr = selected!.Split('|')[0].Replace("ID:", "").Trim();
            return int.Parse(idStr);
        }
    }
}
