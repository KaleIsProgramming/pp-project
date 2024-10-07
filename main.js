const { app, BrowserWindow, session, ipcMain } = require('electron');
const path = require('path');
const { spawn } = require('child_process');

let mainWindow;

// Sprawdzamy, czy aplikacja jest w trybie developerskim
const isDev = !app.isPackaged;

function createWindow() {
  mainWindow = new BrowserWindow({
    width: 1600,
    height: 1200,
    webPreferences: {
      nodeIntegration: true,
      enableRemoteModule: true,
      contextIsolation: false,
      nodeIntegrationInWorker: true,
      nodeIntegrationInSubFrames: true,
    },
  });

  if (isDev) {
    // Tryb deweloperski - ładowanie z serwera deweloperskiego Reacta
    mainWindow.loadURL('http://localhost:3000');
    mainWindow.webContents.openDevTools(); // Otwórz DevTools w trybie deweloperskim
    scriptPath = path.join(__dirname,'app.asar.unpacked','dist', 'main.exe');
    console.log(scriptPath)
  } else {
    // Tryb produkcyjny - ładowanie statycznych plików Reacta
    mainWindow.loadFile(path.join(__dirname, 'dist', 'index.html'));
  }
}

app.whenReady().then(async () => {
  try {
    // Ładowanie rozszerzenia (opcjonalnie, tylko w trybie developerskim)
    if (isDev) {
      await session.defaultSession.loadExtension('C:/Users/pikostecki/AppData/Local/Google/Chrome/User Data/Default/Extensions/lmhkpmbekcpmknklioeibfkpmmfibljd/3.2.5_0', {
        allowFileAccess: true,
      });
    }
  } catch (err) {
    console.error('Failed to load extension:', err);
  }
});

app.whenReady().then(() => createWindow());

app.on('window-all-closed', () => {
  if (process.platform !== 'darwin') app.quit();
});

app.on('activate', () => {
  if (mainWindow === null) createWindow();
});

