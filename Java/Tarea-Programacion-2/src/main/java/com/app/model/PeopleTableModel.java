/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.app.model;

import com.app.enums.Gender;
import com.app.util.ComboBoxDataLoader;
import java.lang.reflect.Field;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.table.AbstractTableModel;

/**
 *
 * @author Wong
 */
public class PeopleTableModel extends AbstractTableModel {

    /**
     *
     */
    private static PeopleTableModel tableModel;

    /**
     *
     */
    private final List<Object[]> peopleList;

    /**
     *
     */
    private final String columnNames[];

    /**
     *
     */
    private PeopleTableModel() {
        columnNames = new String[]{"N°", "Nombre", "Apellido",
            "Numero de cedula", "F. Nacimiento", "Edad",
            "Sexo", "Departamento", "Municipio"};
        peopleList = new ArrayList<>();
    }

    /**
     *
     * @return
     */
    public static PeopleTableModel getTableModel() {
        return tableModel == null
                ? tableModel = new PeopleTableModel()
                : tableModel;
    }

    /**
     *
     * @return
     */
    @Override
    public int getRowCount() {
        return peopleList.size();
    }

    /**
     *
     * @return
     */
    @Override
    public int getColumnCount() {
        return columnNames.length;
    }

    /**
     *
     * @param rowIndex
     * @param columnIndex
     * @return
     */
    @Override
    public boolean isCellEditable(int rowIndex, int columnIndex) {
        return false;
    }

    /**
     *
     * @param columnIndex
     * @return
     */
    @Override
    public Class<?> getColumnClass(int columnIndex) {
        return getValueAt(0, columnIndex).getClass();
    }

    /**
     *
     * @param column
     * @return
     */
    @Override
    public String getColumnName(int column) {
        if (column < 0 || column > columnNames.length) {
            return null;
        }
        return columnNames[column];
    }

    /**
     *
     * @param rowIndex
     * @param columnIndex
     * @return
     */
    @Override
    public Object getValueAt(int rowIndex, int columnIndex) {
        if (peopleList.isEmpty()) {
            return null;
        } else if (rowIndex < 0 || rowIndex > peopleList.size()) {
            return null;
        } else if (columnIndex < 0 || columnIndex > columnNames.length) {
            return null;
        }
        return peopleList.get(rowIndex)[columnIndex];
    }

    /**
     *
     * @param person
     */
    public void addRow(Person person) {
        if (person != null) {
            try {
                peopleList.add(convertToArray(person));
            } catch (IllegalArgumentException | IllegalAccessException ex) {
                Logger.getLogger(PeopleTableModel.class.getName()).log(Level.SEVERE, null, ex);
            }
            fireTableRowsInserted(peopleList.size() - 1, peopleList.size() - 1);
        }
    }

    /**
     *
     * @param selectedRow
     */
    public void deleteRow(int selectedRow) {
        if (selectedRow >= 0 && selectedRow < peopleList.size()) {
            peopleList.remove(selectedRow);
            fireTableRowsDeleted(selectedRow, selectedRow);
        }
    }

    /**
     *
     * @param person
     */
    public void updateRow(Person person) {
        if (person != null) {
            try {
                peopleList.set(person.getPersonId() - 1, convertToArray(person));
            } catch (IllegalArgumentException | IllegalAccessException ex) {
                Logger.getLogger(PeopleTableModel.class.getName()).log(Level.SEVERE, null, ex);
            }
            fireTableRowsUpdated(person.getPersonId() - 1, person.getPersonId() - 1);
        }
    }

    /**
     *
     * @param people
     */
    public void setDataModel(List<Person> people) {
        if (!people.isEmpty() && people.size() > 0) {
            people.forEach((p) -> {
                try {
                    peopleList.add(convertToArray(p));
                } catch (IllegalArgumentException | IllegalAccessException ex) {
                    Logger.getLogger(PeopleTableModel.class.getName()).log(Level.SEVERE, null, ex);
                }
            });
            fireTableDataChanged();
        }
    }

    /**
     *
     * @return
     */
    public List<Person> getDataModel() {
        List<Person> people = new ArrayList<>(peopleList.size());
        peopleList.forEach((row) -> {
            people.add(convertToPerson(row));
        });
        return people;
    }

    /**
     *
     * @param p
     * @return
     */
    private Object[] convertToArray(Person p) throws IllegalArgumentException, IllegalAccessException {
        Field fields[] = Person.class.getDeclaredFields();
        Object[] row = new Object[fields.length];
        int index = 0;
        for (Field f : fields) {
            f.setAccessible(true);
            switch (f.getName()) {
                case "gender":
                    row[index++] = Gender.valueOf(f.get(p).toString()).getValue();
                    break;
                case "municipalityId":
                    int departmentId = p.getDepartmentId();
                    row[index++] = ComboBoxDataLoader.getMunicipalityById(departmentId,
                            Integer.parseInt(f.get(p).toString()));
                    break;
                case "departmentId":
                    row[index++] = ComboBoxDataLoader.getDepartments().get(Integer.parseInt(f.get(p).toString()));
                    break;
                default:
                    row[index++] = f.get(p);
                    break;
            }
        }
        return row;
    }

    /**
     *
     * @param row
     * @return
     */
    private Person convertToPerson(Object[] row) {
        Person temp = new Person();
        temp.setPersonId(Integer.parseInt(row[0].toString()));
        temp.setName(String.valueOf(row[1]));
        temp.setLastName(String.valueOf(row[2]));
        temp.setIdNumber(String.valueOf(row[3]));
        temp.setBirthDay(LocalDate.parse(row[4].toString()));
        temp.setAge(Integer.parseInt(row[5].toString()));
        if (row[6].toString().equals("Masculino")) {
            temp.setGender(Gender.MALE);
        } else {
            temp.setGender(Gender.FEMALE);
        }
        int departmentIndex = ComboBoxDataLoader.getDepartmentIdByName(String.valueOf(row[7]));
        int municipalityIndex = ComboBoxDataLoader.getMunicipalityIdByName(departmentIndex, String.valueOf(row[8]));
        temp.setDepartmentId(departmentIndex);
        temp.setMunicipalityId(municipalityIndex);
        return temp;
    }

    /**
     *
     */
    public void fixPersonIds() {
        int id = 1;
        for (Object[] row : peopleList) {
            Person p = convertToPerson(row);
            p.setPersonId(id);
            try {
                peopleList.set(id - 1, convertToArray(p));
            } catch (IllegalArgumentException | IllegalAccessException ex) {
                Logger.getLogger(PeopleTableModel.class.getName()).log(Level.SEVERE, null, ex);
            }
            id++;
        }
        fireTableDataChanged();
    }
}
