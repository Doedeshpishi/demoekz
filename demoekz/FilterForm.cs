using System;
using System.Windows.Forms;

namespace demoekz
{
    public partial class FilterForm : Form
    {
        public string StatusFilter { get; private set; }
        public string AssigneeFilter { get; private set; }
        public string PriorityFilter { get; private set; }

        public FilterForm(TaskManager taskManager, string statusFilter = null, string assigneeFilter = null, string priorityFilter = null)
        {
            InitializeComponent();
            LoadFilters(taskManager);
            StatusFilter = statusFilter;
            AssigneeFilter = assigneeFilter;
            PriorityFilter = priorityFilter;

            // Установите значения фильтров в элементы управления
            if (!string.IsNullOrEmpty(statusFilter))
            {
                cmbStatusFilter.SelectedItem = statusFilter;
            }
            if (!string.IsNullOrEmpty(assigneeFilter))
            {
                txtExecutor.Text = assigneeFilter;
            }
            if (!string.IsNullOrEmpty(priorityFilter))
            {
                cmbPriorityFilter.SelectedItem = priorityFilter;
            }
        }

        private void LoadFilters(TaskManager taskManager)
        {
            // Загрузка фильтров для статуса и приоритета
            var statuses = taskManager.GetAllStatuses();
            var priorities = taskManager.GetAllPriorities();

            cmbStatusFilter.DataSource = statuses;
            cmbPriorityFilter.DataSource = priorities;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            StatusFilter = cmbStatusFilter.SelectedItem?.ToString();
            AssigneeFilter = txtExecutor.Text;
            PriorityFilter = cmbPriorityFilter.SelectedItem?.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
