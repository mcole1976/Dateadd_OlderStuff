async function fetchDDLData() {
    console.log('GET /api/DDLGet - Request received');

    try {
        // Create AbortController for timeout
        const controller = new AbortController();
        const timeoutId = setTimeout(() => controller.abort(), 50000);

        const response = await fetch('http://localhost:8099/api/Food/Get', {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json',
            },
            signal: controller.signal
        });

        // Clear the timeout since request completed
        clearTimeout(timeoutId);

        if (!response.ok) {
            throw new Error(`HTTP ${response.status}: ${response.statusText}`);
        }

        const data = await response.json();
        console.log('DDL data retrieved successfully');
        return data;

    } catch (error) {
        console.error('Error in /api/DDLGet:', error);

        // Handle specific error types
        if (error.name === 'AbortError') {
            throw new Error('Request timeout - Failed to fetch DDL data');
        }

        throw new Error(`Failed to fetch DDL data: ${error.message}`);
    }
}

// Function to populate dropdown
function populateDropdown(data) {
    const dropdown = document.getElementById('foodTypeDropdown');
    dropdown.innerHTML = '<option value="">Select a food type</option>';

    if (Array.isArray(data)) {
        data.forEach(item => {
            const option = document.createElement('option');
            // Adjust these property names based on your actual API response structure
            option.value = item.id || item.value || item.Id;
            option.textContent = item.name || item.text || item.Name || item.description || item.Description;
            dropdown.appendChild(option);
        });
    } else {
        console.error('Expected array but received:', data);
        showErrorMessage('Invalid data format received from server');
    }
}

// Function to show error messages
function showErrorMessage(message) {
    const errorDiv = document.getElementById('errorMessage');
    errorDiv.textContent = message;
    errorDiv.style.display = 'block';

    // Also update the dropdown to show error state
    const dropdown = document.getElementById('foodTypeDropdown');
    dropdown.innerHTML = '<option value="">Error loading data</option>';
    dropdown.disabled = true;
}

// Function to hide error messages
function hideErrorMessage() {
    const errorDiv = document.getElementById('errorMessage');
    errorDiv.style.display = 'none';
}

// Load DDL data when page loads
async function loadDDLData() {
    try {
        hideErrorMessage();
        const data = await fetchDDLData();
        populateDropdown(data);
    } catch (error) {
        showErrorMessage(error.message);
    }
}

// Load data when DOM is ready
document.addEventListener('DOMContentLoaded', function () {
    loadDDLData();
});

// Optional: Retry function if user wants to retry loading
function retryLoadDDL() {
    const dropdown = document.getElementById('foodTypeDropdown');
    dropdown.innerHTML = '<option value="">Loading...</option>';
    dropdown.disabled = false;
    loadDDLData();
}