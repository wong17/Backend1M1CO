/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.app.controller;

import com.app.enums.Gender;
import com.app.model.PeopleTableModel;
import com.app.model.Person;
import com.app.util.BirthDay;
import com.app.util.ComboBoxDataLoader;
import com.app.util.Validator;
import com.app.view.EditPersonDialog;
import com.app.view.MainFrame;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.net.URISyntaxException;
import java.text.ParseException;
import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.DefaultComboBoxModel;
import javax.swing.JComboBox;
import javax.swing.JOptionPane;
import javax.swing.text.DefaultFormatterFactory;
import javax.swing.text.MaskFormatter;

/**
 *
 * @author Wong
 */
public class EditPersonDialogController {

    /**
     *
     */
    private static EditPersonDialogController editController;

    /**
     *
     */
    private EditPersonDialog dialog;

    /**
     *
     */
    private final EditPersonActionListener actionListener;

    /**
     *
     */
    private final PeopleTableModel tableModel;

    /**
     *
     */
    private EditPersonDialogController() {
        actionListener = new EditPersonActionListener();
        tableModel = PeopleTableModel.getTableModel();
    }

    /**
     *
     * @return
     */
    public static EditPersonDialogController getInstance() {
        return editController == null
                ? editController = new EditPersonDialogController()
                : editController;
    }

    /**
     *
     */
    private void setUpController() {
        addListeners();
        try {
            initComponents();
        } catch (ParseException | URISyntaxException ex) {
            Logger.getLogger(EditPersonDialogController.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    /**
     *
     */
    private void initComponents() throws ParseException, URISyntaxException {
        // Establecemos mascara
        MaskFormatter mask = new MaskFormatter("###-######-####U");
        mask.setPlaceholderCharacter('_');
        dialog.getTxtidNumber().setFormatterFactory(new DefaultFormatterFactory(mask));
        // Cargamos departamentos
        DefaultComboBoxModel departmentModel = new DefaultComboBoxModel();
        departmentModel.addAll(ComboBoxDataLoader.getDepartments());
        dialog.getCmbBoxDepartment().setModel(departmentModel);
        dialog.getCmbBoxDepartment().setSelectedIndex(0);
        dialog.getLblId().setText(String.valueOf(tableModel.getRowCount() + 1));
    }

    /**
     *
     */
    private void addListeners() {
        dialog.getBtnSave().addActionListener(actionListener);
        dialog.getBtnClose().addActionListener(actionListener);
        dialog.getCmbBoxDepartment().addActionListener(actionListener);
    }

    /**
     *
     * @param frame
     * @param mode
     * @param table
     */
    public void showDialog(MainFrame frame, int selectedRow) {
        dialog = new EditPersonDialog(frame, true);
        setUpController();
        fillComponents(selectedRow);
        dialog.setVisible(true);
    }

    /**
     *
     * @param selectedRow
     */
    private void fillComponents(int selectedRow) {
        Person p = tableModel.getDataModel().get(selectedRow);
        dialog.getLblId().setText(String.valueOf(p.getPersonId()));
        dialog.getTxtidNumber().setText(p.getIdNumber());
        dialog.getTxtName().setText(p.getName());
        dialog.getTxtLastname().setText(p.getLastName());
        if (p.getGender() == Gender.MALE) {
            dialog.getRadioBtnMale().setSelected(true);
        } else {
            dialog.getRadioBtnFemale().setSelected(true);
        }
        dialog.getCmbBoxDepartment().setSelectedIndex(p.getDepartmentId());
        dialog.getCmbMunicipality().setSelectedIndex(p.getMunicipalityId());
    }

    /**
     *
     */
    private class EditPersonActionListener implements ActionListener {

        /**
         *
         */
        private final Map<Integer, String[]> map;

        /**
         *
         */
        public EditPersonActionListener() {
            map = new HashMap<>();
            map.putAll(ComboBoxDataLoader.getMunicipalities());
        }

        /**
         *
         * @param e
         */
        @Override
        public void actionPerformed(ActionEvent e) {
            switch (e.getActionCommand()) {
                case "Actualizar":
                    updatePerson();
                    break;
                case "cmbBoxDepartment":
                    loadMunicipalities(e);
                    break;
                case "Cerrar":
                    dialog.dispose();
                    break;
                default:
                    break;
            }
        }

        /**
         *
         */
        private void updatePerson() {
            validateFields();
        }

        /**
         *
         */
        private void validateFields() {
            if (dialog.getTxtidNumber().getText().contains("_")) {
                JOptionPane.showMessageDialog(dialog, "El numero de cedula es obligatorio",
                        "Atención!", JOptionPane.WARNING_MESSAGE);
                return;
            }
            if (!dialog.getRadioBtnFemale().isSelected()
                    && !dialog.getRadioBtnMale().isSelected()) {
                JOptionPane.showMessageDialog(dialog, "Debe seleccionar un sexo", "Atención!",
                        JOptionPane.WARNING_MESSAGE);
                return;
            }
            if (dialog.getTxtName().getText().isBlank()
                    || dialog.getTxtLastname().getText().isBlank()) {
                JOptionPane.showMessageDialog(dialog, "Nombre y apellido obligatorio", "Atención!",
                        JOptionPane.WARNING_MESSAGE);
                return;
            }
            if (!Validator.validateIDNumber(dialog.getTxtidNumber().getText())) {
                JOptionPane.showMessageDialog(dialog, "Verificar dia, mes o año en el numero de cedula"
                        + "\n Dia: 01-31"
                        + "\n Mes: 01-12"
                        + "\n Año: 60'-04' (16 años min)",
                        "Atención!", JOptionPane.WARNING_MESSAGE);
                return;
            }
            if (dialog.getCmbBoxDepartment().getSelectedIndex() == 0) {
                JOptionPane.showMessageDialog(dialog, "Debe seleccionar un departamento y un municipio",
                        "Atención!", JOptionPane.WARNING_MESSAGE);
                return;
            }
            update();
        }

        /**
         *
         */
        private void update() {
            Person person = new Person();
            person.setPersonId(Integer.parseInt(dialog.getLblId().getText()));
            person.setIdNumber(dialog.getTxtidNumber().getText());
            person.setName(dialog.getTxtName().getText());
            person.setLastName(dialog.getTxtLastname().getText());
            person.setBirthDay(BirthDay.getBirthDay(dialog.getTxtidNumber().getText()));
            person.setAge(BirthDay.getAge(dialog.getTxtidNumber().getText()));
            if (dialog.getRadioBtnMale().isSelected()) {
                person.setGender(Gender.MALE);
            } else {
                person.setGender(Gender.FEMALE);
            }
            int departmentIndex = dialog.getCmbBoxDepartment().getSelectedIndex();
            int municipalityIndex = dialog.getCmbMunicipality().getSelectedIndex();
            person.setDepartmentId(departmentIndex);
            person.setMunicipalityId(municipalityIndex);
            tableModel.updateRow(person);
            dialog.dispose();
        }

        /**
         *
         * @param e
         */
        private void loadMunicipalities(ActionEvent e) {
            JComboBox cmb = (JComboBox) e.getSource();
            int index = cmb.getSelectedIndex();
            DefaultComboBoxModel model = new DefaultComboBoxModel();
            if (index >= 1) {
                model.addAll(Arrays.asList(map.get(Integer.parseInt(String.valueOf(index)))));
                dialog.getCmbMunicipality().setModel(model);
                if (dialog.getCmbMunicipality().getModel().getSize() > 0) {
                    dialog.getCmbMunicipality().setSelectedIndex(0);
                }
            }
        }

    }
}
