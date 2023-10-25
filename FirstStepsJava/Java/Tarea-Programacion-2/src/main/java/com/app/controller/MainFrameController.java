/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.app.controller;

import com.app.enums.DataFilePaths;
import com.app.model.PeopleTableModel;
import com.app.util.FileUtilities;
import com.app.view.MainFrame;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.nio.file.Paths;

/**
 *
 * @author Wong
 */
public class MainFrameController {

    /**
     *
     */
    private static MainFrameController mainController;

    /**
     *
     */
    private final MainFrame frame;

    /**
     *
     */
    private final MainFrameActionListener actionListener;

    /**
     *
     */
    private final MainFrameWindowListener windowListener;

    /**
     *
     */
    private final PeopleTableModel tableModel;

    /**
     *
     */
    private MainFrameController() {
        frame = new MainFrame();
        actionListener = new MainFrameActionListener();
        windowListener = new MainFrameWindowListener();
        tableModel = PeopleTableModel.getTableModel();
    }

    /**
     *
     * @return
     */
    public static MainFrameController getMainFrameController() {
        return mainController == null
                ? mainController = new MainFrameController()
                : mainController;
    }

    /**
     *
     */
    private void setUpController() {
        addListeners();
        initComponents();
    }

    /**
     *
     */
    private void addListeners() {
        frame.addWindowListener(windowListener);
        frame.getBtnNew().addActionListener(actionListener);
        frame.getBtnDelete().addActionListener(actionListener);
        frame.getBtnEdit().addActionListener(actionListener);
    }

    /**
     *
     */
    private void initComponents() {
        tableModel.setDataModel(FileUtilities.getAll(Paths.get(DataFilePaths.DATA_FILE_PATH.getValue())));
        frame.getPeopleTable().setModel(tableModel);
    }

    /**
     *
     */
    public void showMainFrame() {
        setUpController();
        frame.setVisible(true);
    }

    /**
     *
     */
    private class MainFrameActionListener implements ActionListener {

        /**
         *
         * @param e
         */
        @Override
        public void actionPerformed(ActionEvent e) {
            switch (e.getActionCommand()) {
                case "Nuevo":
                    RegistrationDialogController.getInstance().showDialog(frame);
                    break;
                case "Editar":
                    editPerson();
                    break;
                case "Eliminar":
                    removePerson();
                    break;
                case "cmbBoxFinder":
                    break;
                default:
                    break;
            }
        }

        /**
         *
         */
        private void removePerson() {
            tableModel.deleteRow(frame.getPeopleTable().getSelectedRow());
            tableModel.fixPersonIds();
        }

        /**
         *
         */
        private void editPerson() {
            int index = frame.getPeopleTable().getSelectedRow();
            if (index >= 0) {
                EditPersonDialogController.getInstance().showDialog(frame, index);
            }
        }
    }

    /**
     *
     */
    private class MainFrameWindowListener extends WindowAdapter {

        /**
         *
         * @param e
         */
        @Override
        public void windowClosing(WindowEvent e) {
            FileUtilities.saveAll(tableModel.getDataModel(),
                    Paths.get(DataFilePaths.DATA_FILE_PATH.getValue()));
        }
    }
}
