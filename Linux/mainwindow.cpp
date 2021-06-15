#include "mainwindow.h"
#include "ui_mainwindow.h"

#include <QSystemTrayIcon>

QIcon trayIcon;

MainWindow::MainWindow(QWidget *parent): QMainWindow(parent), ui(new Ui::MainWindow) {
    ui->setupUi(this);

    mSystemTrayIcon = new QSystemTrayIcon(this);
    trayIcon = QIcon("://favicon.ico");



    mSystemTrayIcon->setIcon(trayIcon);

    mSystemTrayIcon->setToolTip("Drink it up!");

    mSystemTrayIcon->setVisible(true);

    setWindowIcon(QIcon("://favicon.ico"));
}

// On window closing
MainWindow::~MainWindow() {
    //delete ui;
    mSystemTrayIcon->showMessage(tr("Hi"), tr("Test Message"), trayIcon);
}
