# ConnectPLC

## 專案簡介
ConnectPLC 是一個用於與多種 PLC (可程式邏輯控制器) 進行通訊的應用程式。此專案支援多種 PLC 型號，並提供讀取與寫入 PLC 資料的功能。

## 功能
- 支援多種 PLC 型號，包括 Mitsubishi、Siemens、AB、Omron。
- 提供連線、讀取與寫入 PLC 資料的功能。
- 使用策略模式來切換不同的 PLC 連線策略。

## 使用方式
1. 啟動應用程式。
2. 輸入 PLC 的 IP 位址與 Port。
3. 選擇 PLC 型號。
4. 點擊「連線」按鈕進行連線。
5. 使用「讀取」或「寫入」功能來操作 PLC 資料。

## 程式碼結構
- `MainForm.cs`: 主視窗邏輯，包含連線、讀取與寫入的操作。
- `PlcConnector.cs`: 負責與 PLC 進行通訊的核心類別。
- `IConnectionStrategy.cs`: 定義 PLC 連線策略的介面。
- `MitsubishiPlcConnectionStrategy.cs`, `SiemensPlcConnectionStrategy.cs`, `ABPlcConnectionStrategy.cs`, `OmronPlcConnectionStrategy.cs`: 各 PLC 型號的連線策略實作。

## 開發環境
- .NET 8 (Windows Forms)
- Visual Studio 2022 或以上
- 僅支援 Windows 平台執行

## 建構與執行
1. 於 Windows 平台安裝 .NET 8 SDK 與 Visual Studio 2022 以上版本。
2. 於專案目錄下執行：
   ```
   dotnet build
   dotnet run
   ```
   或於 Visual Studio 直接開啟並執行。

> 注意：本專案雖可在 Linux 進行建構，但僅能於 Windows 執行。

## 注意事項
- 請確保輸入的 IP 位址與 Port 正確無誤。
- 使用前請確認 PLC 型號是否支援。

## 貢獻
歡迎對此專案進行改進或提出建議，請透過 Pull Request 或 Issue 與我們聯繫。

## 授權
此專案採用 MIT 授權條款。